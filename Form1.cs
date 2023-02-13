using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTestWindowsForms
{
    public partial class TestNewTable : Form
    {
        public TestNewTable()
        {
            InitializeComponent();
            startNewTable();
        }

        /* Отправил на Git 13.02.2023 */
        public void startNewTable()
        {
            /* Сначала задаю струкутру своей таблицы и прописываю имя и название ячеек */

            // создаем колонку 1 - Фамилия
            DataGridViewTextBoxColumn coloum_0 = new DataGridViewTextBoxColumn();
            coloum_0.Name = "Name1";
            coloum_0.HeaderText = "Фамилия";

            // создаем колонку 2 - Имя
            DataGridViewTextBoxColumn coloum_1 = new DataGridViewTextBoxColumn();
            coloum_1.Name = "Name2";
            coloum_1.HeaderText = "Имя";

            // создаем колонку 3 - Отчетсво
            DataGridViewTextBoxColumn coloum_2 = new DataGridViewTextBoxColumn();
            coloum_2.Name = "Name3";
            coloum_2.HeaderText = "Отчество";
             
            // создаем колонку 4 - Личный код
            DataGridViewTextBoxColumn coloum_3 = new DataGridViewTextBoxColumn();
            coloum_3.Name = "ServiceInformation";
            coloum_3.HeaderText = "Личный код";

            // Заносим созданные колонки в таблицу
            newTable.Columns.AddRange(coloum_0, coloum_1, coloum_2, coloum_3);


            /* Заполняем ячейкии (Создаем строки) */

            // Строка 1
            DataGridViewCell Name1_0 = new DataGridViewTextBoxCell();
            DataGridViewCell Name2_0 = new DataGridViewTextBoxCell();
            DataGridViewCell Name3_0 = new DataGridViewTextBoxCell();
            DataGridViewCell Name4_0 = new DataGridViewTextBoxCell();

            Name1_0.Value = "Петров";
            Name2_0.Value = "Иван";
            Name3_0.Value = "Сергеевич";
            Name4_0.Value = "00001";

            DataGridViewRow row_0 = new DataGridViewRow();
            row_0.Cells.AddRange(Name1_0, Name2_0, Name3_0, Name4_0);
            newTable.Rows.Add(row_0);

            // Строка 2
            DataGridViewCell Name1_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Name2_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Name3_1 = new DataGridViewTextBoxCell();
            DataGridViewCell Name4_1 = new DataGridViewTextBoxCell();

            Name1_1.Value = "Сидоров";
            Name2_1.Value = "Андрей";
            Name3_1.Value = "Дмитриевич";
            Name4_1.Value = "00002";

            DataGridViewRow row_1 = new DataGridViewRow();
            row_1.Cells.AddRange(Name1_1, Name2_1, Name3_1, Name4_1);
            newTable.Rows.Add(row_1);
        }
    }
}
