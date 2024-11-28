﻿using ObjectOrientedPractics.Services;
using System;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город(населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен состоять из 6 цифр.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentException("Индекс должен состоять из 6 цифр.");
                }
                if (_index != value)
                {
                    var args = new EventArgs();
                    _index = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну/регион. Не должна быть длиннее 50 символов.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50);
                if (_country != value)
                {
                    var args = new EventArgs();
                    _country = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает или задает город(населенный пункт). Не должен быть длиннее 50 символов.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50);
                if (_city != value)
                {
                    var args = new EventArgs();
                    _city = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает или задает улицу. Не должна быть длиннее 100 символов.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100);
                if (_street != value)
                {
                    var args = new EventArgs();
                    _street = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Врзвращает или задает номер дома. Не должен быть длиннее 10 символов.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10);
                if (_building != value)
                {
                    var args = new EventArgs();
                    _building = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает или задает номер квартиры/помещения. Не должен быть длиннее 10 символов.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10);
                if (_apartment != value)
                {
                    var args = new EventArgs();
                    _apartment = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/> без его инициализации.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен состоять из 6 цифр.</param>
        /// <param name="country">Страна/регион. Не должна быть длиннее 50 символов.</param>
        /// <param name="city">Город(населенный пункт). Не должен быть длиннее 50 символов.</param>
        /// <param name="street">Улица. Не должна быть длиннее 100 символов.</param>
        /// <param name="building">Номер дома. Не должен быть длиннее 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не должен быть длиннее 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(
                Index,
                Country,
                City,
                Street,
                Building,
                Apartment);
        }

        /// <inheritdoc/>
        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Index == other.Index && Country == other.Country && City == other.City
                && Street == other.Street && Building == other.Building && Apartment == other.Apartment;
        }
    }
}