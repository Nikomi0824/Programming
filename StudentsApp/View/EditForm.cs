﻿using StudentsApp.Model.Classes;
using StudentsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp.View
{
    public partial class EditForm : Form
    {
        /// <summary>
        /// Скопированный изменяемый студент.
        /// </summary>
        private Student _copiedStudent;

        /// <summary>
        /// Возвращает или задает изменяемого студента.
        /// </summary>
        public Student CurrentStudent { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="EditForm"/>.
        /// Заполняет все поля формы данными студента, которого нужно изменить
        /// и копирует их в новый экземпляр класса.
        /// </summary>
        /// <param name="student">Студент, которого нужно изменить.</param>
        public EditForm(Student student)
        {
            InitializeComponent();
            _copiedStudent = Student.CopyStudent(student);
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
            RecordNumberTextBox.ReadOnly = true;
        }

        /// <summary>
        /// При изменении текста FullNameTextBox пытается присвоить этот текст в свойство FullName элемента
        /// _copiedStudent и красит FullNameTextBox в соответствии с валидацией.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _copiedStudent.FullName = FullNameTextBox.Text;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении текста GroupTextBox пытается присвоить этот текст в свойство Group элемента
        /// _copiedStudent и красит GroupTextBox в соответствии с валидацией.
        /// </summary>
        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GroupTextBox.BackColor = Color.White;
                _copiedStudent.Group = GroupTextBox.Text;
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При выборе нового значения FacultyComboBox 
        /// присваивает его в свойство Faculty элемента _copiedStudent.
        /// </summary>
        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _copiedStudent.Faculty = FacultyComboBox.Text;
        }

        /// <summary>
        /// При выборе нового значения FormOfEducationComboBox 
        /// присваивает его в свойство FormOfEducation элемента _copiedStudent.
        /// </summary>
        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _copiedStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }

        /// <summary>
        /// При нажатии на кнопку удаления студента удаляет студента и закрывает форму.
        /// </summary>
        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// При нажатии на кнопку мзменения студента, если все поля экземпляра студента
        /// не пустые и значения допустимы, то передает его в свойство CurrentStudent и закрывает форму.
        /// </summary>
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            if (_copiedStudent.FullName == null || _copiedStudent.Group == null ||
                _copiedStudent.Faculty == null || _copiedStudent.FormOfEducation == null)
            {
                return;
            }
            if (FullNameTextBox.Text.Length > 200 || GroupTextBox.Text.Length > 10)
            {
                return;
            }
            CurrentStudent = _copiedStudent;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
