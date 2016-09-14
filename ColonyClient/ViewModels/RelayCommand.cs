using System;
using System.Windows.Input;

namespace ColonyClient
{
	/// <summary>
	/// Relay command.
	/// </summary>
	public class RelayCommand : ICommand
	{
		/// <summary>
		/// The execute.
		/// </summary>
		private readonly Action _execute;
		/// <summary>
		/// The can execute.
		/// </summary>
		private readonly Func<bool> _canExecute;
		/// <summary>
		/// Occurs when can execute changed.
		/// </summary>
		public event EventHandler CanExecuteChanged;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.RelayCommand"/> class.
		/// </summary>
		/// <param name="execute">Execute.</param>
		public RelayCommand(Action execute) : this(execute, null) { }
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.RelayCommand"/> class.
		/// </summary>
		/// <param name="execute">Execute.</param>
		/// <param name="canExecute">Can execute.</param>
		public RelayCommand(Action execute, Func<bool> canExecute)
		{
			if (execute == null) throw new ArgumentException("Execute!");
			_execute = execute;
			_canExecute = canExecute;
		}
		/// <summary>
		/// Cans the execute.
		/// </summary>
		/// <returns><c>true</c>, if execute was caned, <c>false</c> otherwise.</returns>
		/// <param name="parameter">Parameter.</param>
		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute();
		}
		/// <summary>
		/// Execute the specified parameter.
		/// </summary>
		/// <param name="parameter">Parameter.</param>
		public void Execute(object parameter)
		{
			_execute();
		}
		/// <summary>
		/// Raises the can execute changed.
		/// </summary>
		public void RaiseCanExecuteChanged()
		{
			var handler = CanExecuteChanged;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}
	}

	/// <summary>
	/// Relay command.
	/// </summary>
	public class RelayCommand<T> : ICommand
	{
		/// <summary>
		/// The execute.
		/// </summary>
		private readonly Action<T> _execute;
		/// <summary>
		/// The can execute.
		/// </summary>
		private readonly Func<T, bool> _canExecute;
		/// <summary>
		/// Occurs when can execute changed.
		/// </summary>
		public event EventHandler CanExecuteChanged;
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.RelayCommand`1"/> class.
		/// </summary>
		/// <param name="execute">Execute.</param>
		public RelayCommand(Action<T> execute) : this(execute, null) { }
		/// <summary>
		/// Initializes a new instance of the <see cref="T:ColonyClient.RelayCommand`1"/> class.
		/// </summary>
		/// <param name="execute">Execute.</param>
		/// <param name="canExecute">Can execute.</param>
		public RelayCommand(Action<T> execute, Func<T, bool> canExecute)
		{
			if (execute == null) throw new ArgumentException("Execute!");
			_execute = execute;
			_canExecute = canExecute;
		}
		/// <summary>
		/// Cans the execute.
		/// </summary>
		/// <returns><c>true</c>, if execute was caned, <c>false</c> otherwise.</returns>
		/// <param name="parameter">Parameter.</param>
		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute((T)parameter);
		}
		/// <summary>
		/// Execute the specified parameter.
		/// </summary>
		/// <param name="parameter">Parameter.</param>
		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}
		/// <summary>
		/// Raises the can execute changed.
		/// </summary>
		public void RaiseCanExecuteChanged()
		{
			var handler = CanExecuteChanged;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}
	}
}

