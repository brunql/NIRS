
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Division:ActiveRecord
	{

        private int id = 0;

        public int Id
        {
            get { return id; }
        }

		private string name = "aaa";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
         
        private int fac_id;
        public int FacId { get { return fac_id; } set { fac_id = value; } }

		private Faculty fac;

        public Faculty Faculty
        {
            get { return fac; }
            set 
            { 
                fac = value;
                fac_id = value.Id;
            }
        }
        		
		
		public Division()
		{
		     tableName = "division";	
		}
		
		public override ActiveRecord Find (DBCriteria crit)
		{
			throw new System.NotImplementedException ();
		}
		
		public override void Delete (int id)
		{
			throw new System.NotImplementedException ();
		}

		public override void Save ()
		{
            string query = "";
            if (id == 0)
            {
                query = "INSERT INTO `" + tableName + "` VALUES(null," + fac_id + ",'" + name.ToString()+ "');";
            }
            else
            {
                query = "UPDATE `" + tableName + "` `name`=\"" + name + "\",`fac_id`=" + fac_id + 
                    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
		}

		
	}
}
