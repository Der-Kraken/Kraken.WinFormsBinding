using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kraken.WinFormsBinding.Tools
{
    public class ObservablePropertyChangedEventArgs : EventArgs
    {
        public ObservablePropertyChangedEventArgs(INotifyPropertyChanged changedObject, PropertyChangedEventArgs eventArgs)
        {
            ChangedObject = changedObject;
            PropertyChangedDetails = eventArgs;
        }

        public INotifyPropertyChanged ChangedObject { get; }
        public PropertyChangedEventArgs PropertyChangedDetails { get; }
    }

    public class PropertyChangedObserver : IDisposable
    {
        // Fields

        private MetaHelper _metaHelper;
        private IEnumerable<INotifyPropertyChanged> _observingObjects;
        private bool _isDisposed;

        // Constructor

        public PropertyChangedObserver(INotifyPropertyChanged rootObservable, string propertyPath)
        {
            ObservableRoot = rootObservable ?? throw new System.ArgumentNullException(nameof(rootObservable));
            PropertyPath = propertyPath ?? throw new System.ArgumentNullException(nameof(propertyPath));

            _metaHelper = new MetaHelper();
        }

        // Properties

        /// <summary>
        /// The root object for the property path.
        /// </summary>
        public INotifyPropertyChanged ObservableRoot { get; }

        /// <summary>
        /// The path to observe if any property value is changing.
        /// </summary>
        public string PropertyPath { get; }

        /// <summary>
        /// True if observing ist active.
        /// </summary>
        public bool IsObserving { get; private set; }

        // Events

        public event EventHandler<ObservablePropertyChangedEventArgs> ObservablePropertyChanged;
        protected virtual void OnObservablePropertyChanged(INotifyPropertyChanged changedObject, PropertyChangedEventArgs eventArgs)
        {
            var args = new ObservablePropertyChangedEventArgs(changedObject, eventArgs);
            ObservablePropertyChanged?.Invoke(this, args);
        }

        // Methods

        public void StartObserving()
        {
            if (_isDisposed) throw new ObjectDisposedException(GetType().Name);
            if (IsObserving) throw new FormatException("Cannot start observe while observing.");

            IsObserving = true;

            var values = _metaHelper.ResolvePropertyPath(ObservableRoot, PropertyPath);
            _observingObjects = values.OfType<INotifyPropertyChanged>();

            foreach (var observable in _observingObjects)
            {
                observable.PropertyChanged += AnyObservable_PropertyChanged;
            }
        }

        private void RestartObserving()
        {
            if (IsObserving)
            {
                StopObserving();
            }
            StartObserving();
        }

        private void StopObserving()
        {
            if (!IsObserving) throw new FormatException("Cannot stop observe because it stopped already.");

            IsObserving = false;

            foreach (var observable in _observingObjects)
            {
                observable.PropertyChanged -= AnyObservable_PropertyChanged;
            }
            _observingObjects = null;
        }

        private void AnyObservable_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnObservablePropertyChanged((INotifyPropertyChanged)sender, e);

            // Restart is required because the underlying observing objects has changed.
            RestartObserving();
        }

        public void Dispose()
        {
            if (_isDisposed) return;

            _isDisposed = true;

            StopObserving();
        }
    }
}
