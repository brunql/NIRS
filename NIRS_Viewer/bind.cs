﻿/*
 * Created by SharpDevelop.
 * User: Администратор
 * Date: 21.03.2010
 * Time: 0:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace NIRS_Viewer
{
	/// <summary>
	/// Description of bind.
	/// </summary>
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
