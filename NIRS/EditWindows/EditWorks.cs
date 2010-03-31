using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace NIRS
{
    public partial class EditWorks : WindowsEditBaseForm
    {
        public EditWorks() : base() { }

        protected override void InitializeDataViewAndBindings()
        {
            this.Text = "Редактирование научных работ";
            dataBinding.DataMember = "works";

            DataGridInitializer.InitWorks(dataGridView);
        }

        protected override void DataGridView_RowsRemoving()
        {
            Console.WriteLine("Hello from the past! We are 08-K-PO1 and we wrote this stuff :)");
        }
    }
}
