using System;
using System.Data;

namespace NIRS_Viewer
{
	public class bind : System.Windows.Forms.BindingSource
	{
		static bind()
		{
            NIRS_Viewer.config.Initialize("server=localhost; port=3306; user id=root; password=; database=nirs; CHARACTER SET=utf8");
		}
		
		public bind()
		{
			this.DataSource = config.NIRS_DataSet;
		}

        public void Fill()
        {
            config.Fill(this.DataMember);
        }

        public void Save()
        {
            config.Save(this.DataMember);
        }
		
		public nirsDataSetMain nirs_DataSet {get {return config.NIRS_DataSet;}}
		public DataTable current_DataTable {get {return config.NIRS_DataSet.Tables[this.DataMember];}}
	}
}
