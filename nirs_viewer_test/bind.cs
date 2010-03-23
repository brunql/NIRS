/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 0:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace nirs_viewer
{
	/// <summary>
	/// Description of bind.
	/// </summary>
	public class bind : System.Windows.Forms.BindingSource
	{
		static bind()
		{
			nirs_viewer.config.Initialize("server=localhost; port=3306; user id=root; password=; database=nirs; CHARACTER SET=utf8");
		}
		
		public bind()
		{
			this.DataSource = config.NIRS_DataSet;
		}
		
		public void Fill()
		{
			config.Fill(this.DataMember);
		}
		
		public void Update()
		{
			config.Update(this.DataMember);
		}
		
		public DataSet nirs_DataSet {get {return config.NIRS_DataSet;}}
		public DataTable current_DataTable {get {return config.NIRS_DataSet.Tables[this.DataMember];}}
	}
}
