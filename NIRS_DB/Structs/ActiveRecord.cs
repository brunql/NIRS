
using System;

namespace NIRS_DB
{
	
	
	public abstract class ActiveRecord
	{
		protected string tableName;
		
		public ActiveRecord()
		{
			
		}
		
		protected void MakeRequest(string query)
		{
			DBConnection.Request(query);	
		}
		
		public abstract ActiveRecord Find(DBCriteria crit);
		
		public abstract void Delete(int id);
		
		public abstract void Save();
		
		
	}
}
