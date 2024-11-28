using Newtonsoft.Json;
using StudentsApp.Model.Classes;
using System.ComponentModel;
using StudentsApp.Model.Enums;
using StudentsApp.View;

namespace StudentsApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список студентов, используемый для привязки данных.
        /// </summary>
        private BindingList<Student> _students = new BindingList<Student>();

        /// <summary>
        /// Путь к директории, где будет храниться JSON-файл.
        /// </summary>
        private string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp";

        /// <summary>
        /// Путь к JSON-файлу, содержащему данные студентов.
        /// </summary>
        private string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp\\students.json";

        /// <summary>
        /// Конструктор формы, инициализирующий компоненты и загружающий данные студентов.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeDataPaths();
            LoadStudentsFromJson();
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
            RecordNumberTextBox.ReadOnly = true;
            FullNameTextBox.ReadOnly = true;
            GroupTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Инициализирует пути к директории и файлу JSON.
        /// Создает директорию, если она не существует, и создает файл, если он отсутствует.
        /// </summary>
        private void InitializeDataPaths()
        {
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Загружает студентов из JSON-файла и добавляет их в список студентов.
        /// </summary>
        private void LoadStudentsFromJson()
        {
            using (JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath)))
            {
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Student tempStudent = serializer.Deserialize<Student>(reader);
                    _students.Add(tempStudent);
                }
            }
        }

        /// <summary>
        /// Сортирует список студентов по полному имени.
        /// </summary>
        private void StudentsSort()
        {
            int size = _students.Count;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (String.Compare(_students.ElementAt(j).FullName, _students.ElementAt(j + 1).FullName) > 0)
                    {
                        Student temp = _students.ElementAt(j);
                        _students[j] = _students.ElementAt(j + 1);
                        _students[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет текстовые поля формы с информацией о выбранном студенте.
        /// </summary>
        /// <param name="student">Студент, информация о котором будет отображена.</param>
        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        /// <summary>
        /// Очищает текстовые поля формы, сбрасывая их значения.
        /// </summary>
        private void ClearStudentsInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            RecordNumberTextBox.Clear();
            GroupTextBox.Clear();
            GroupTextBox.BackColor = Color.White;
            FacultyComboBox.Text = "";
            FormOfEducationComboBox.Text = "";
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке студентов.
        /// Обновляет информацию о студенте или очищает поля, если ничего не выбрано.
        /// </summary>
        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex != -1)
            {
                UpdateStudentsInfo(_students[StudentsListBox.SelectedIndex]);
            }
            else
            {
                ClearStudentsInfo();
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления студента.
        /// Открывает форму редактирования и добавляет нового студента в список.
        /// </summary>
        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Student());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _students.Add(editForm.CurrentStudent);
                SaveStudentsToJson();
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку редактирования студента.
        /// Удаляет выбранного студента из списка и обновляет JSON-файл.
        /// </summary>
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _students.RemoveAt(selectedIndex);
                StudentsListBox.SelectedIndex = -1;
                SaveStudentsToJson();
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку удаления студента.
        /// Открывает форму редактирования для выбранного студента и обновляет список.
        /// </summary>
        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditForm editForm = new EditForm(_students[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _students[selectedIndex] = editForm.CurrentStudent;
                }
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
            SaveStudentsToJson();
        }

        /// <summary>
        /// Сохраняет список студентов в JSON-файл.
        /// </summary>
        private void SaveStudentsToJson()
        {
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _students.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
            }
        }
    }
}
