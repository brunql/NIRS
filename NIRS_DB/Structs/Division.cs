
using System;

namespace NIRS_DB.Structs
{
	
	
	public class Division : ActiveRecord
	{
        public int Id { get; private set; }
        public string Name { get; set; }
        public int FacId { get; set; }

		private Faculty fac;

        public Faculty Faculty
        {
            get { return fac; }
            set 
            { 
                fac = value;
                FacId = value.Id;
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
            if (Id == 0)
            {
                query = string.Format("INSERT INTO `{0}` VALUES(null, {1}, '{2}');", tableName, FacId, Name);
            }
            else
            {
                throw new NotImplementedException();
                //query = "UPDATE `" + tableName + "` `name`=\"" + name + "\",`fac_id`=" + fac_id + 
                //    " WHERE `id`=" + id + ";";
            }

            MakeRequest(query);
		}

		
	}
}
