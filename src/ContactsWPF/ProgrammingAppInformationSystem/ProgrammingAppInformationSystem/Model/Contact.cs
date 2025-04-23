using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

/// <summary>
/// Представляет контактную информацию, включая имя, телефон и email.
/// Реализует интерфейсы INotifyPropertyChanged и INotifyDataErrorInfo для поддержки
/// уведомлений об изменении свойств и валидации данных в реальном времени.
/// </summary>
public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
{
    private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string _name;

    /// <summary>
    /// Почта контакта.
    /// </summary>
    private string _email;

    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    private string _phone;

    /// <summary>
    /// Получает или задает имя контакта.
    /// При установке значения автоматически выполняется валидация и уведомление об изменении.
    /// </summary>
    /// <remarks>
    /// Имя должно быть не пустым и не превышать 100 символов.
    /// </remarks>
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            ValidateName();
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Получает или задает email контакта.
    /// При установке значения автоматически выполняется валидация и уведомление об изменении.
    /// </summary>
    /// <remarks>
    /// Email должен содержать символ '@', быть не пустым и не превышать 100 символов.
    /// </remarks>
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            ValidateEmail();
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Получает или задает телефонный номер контакта.
    /// При установке значения автоматически выполняется валидация и уведомление об изменении.
    /// </summary>
    /// <remarks>
    /// Номер телефона должен содержать только цифры и символы +-(), быть не пустым
    /// и не превышать 100 символов.
    /// </remarks>
    public string Phone
    {
        get => _phone;
        set
        {
            _phone = value;
            ValidatePhone();
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Выполняет валидацию имени контакта.
    /// </summary>
    private void ValidateName()
    {
        ClearErrors(nameof(Name));
        if (string.IsNullOrWhiteSpace(_name))
            AddError(nameof(Name), "Name is required.");
        else if (_name.Length > 100)
            AddError(nameof(Name), "Name must not exceed 100 characters.");
    }

    /// <summary>
    /// Выполняет валидацию email контакта.
    /// </summary>
    private void ValidateEmail()
    {
        ClearErrors(nameof(Email));
        if (string.IsNullOrWhiteSpace(_email))
            AddError(nameof(Email), "Email is required.");
        else if (_email.Length > 100)
            AddError(nameof(Email), "Email must not exceed 100 characters.");
        else if (!_email.Contains("@"))
            AddError(nameof(Email), "Email must contain '@' symbol.");
    }

    /// <summary>
    /// Выполняет валидацию телефонного номера контакта.
    /// </summary>
    private void ValidatePhone()
    {
        ClearErrors(nameof(Phone));
        if (string.IsNullOrWhiteSpace(_phone))
            AddError(nameof(Phone), "Phone number is required.");
        else if (_phone.Length > 100)
            AddError(nameof(Phone), "Phone number must not exceed 100 characters.");
        else if (!Regex.IsMatch(_phone, @"^[0-9+\-() \.]+$"))
            AddError(nameof(Phone), "Phone number can only contain digits and +-() characters.");
    }

    /// <summary>
    /// Добавляет сообщение об ошибке для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя свойства, для которого добавляется ошибка.</param>
    /// <param name="error">Сообщение об ошибке.</param>
    private void AddError(string propertyName, string error)
    {
        if (!_errors.ContainsKey(propertyName))
            _errors[propertyName] = new List<string>();

        if (!_errors[propertyName].Contains(error))
        {
            _errors[propertyName].Add(error);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// Очищает все ошибки для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя свойства, для которого очищаются ошибки.</param>
    private void ClearErrors(string propertyName)
    {
        if (_errors.ContainsKey(propertyName))
        {
            _errors.Remove(propertyName);
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// Возвращает значение, указывающее, есть ли ошибки валидации.
    /// </summary>
    public bool HasErrors => _errors.Any();

    /// <summary>
    /// Событие, возникающее при изменении ошибок валидации.
    /// </summary>
    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    /// <summary>
    /// Событие, возникающее при изменении значения свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Возвращает список ошибок для указанного свойства.
    /// </summary>
    /// <param name="propertyName">Имя свойства, для которого запрашиваются ошибки.</param>
    /// <returns>Список сообщений об ошибках или null, если ошибок нет.</returns>
    public IEnumerable GetErrors(string propertyName)
    {
        return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
    }

    /// <summary>
    /// Вызывает событие PropertyChanged для уведомления об изменении свойства.
    /// </summary>
    /// <param name="propertyName">Имя изменившегося свойства.</param>
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}