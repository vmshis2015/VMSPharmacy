using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace VNS.HIS.DAL
{
    /// <summary>
    /// Controller class for t_lichsu_chotthuoc
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TLichsuChotthuocController
    {
        // Preload our schema..
        TLichsuChotthuoc thisSchemaLoad = new TLichsuChotthuoc();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TLichsuChotthuocCollection FetchAll()
        {
            TLichsuChotthuocCollection coll = new TLichsuChotthuocCollection();
            Query qry = new Query(TLichsuChotthuoc.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TLichsuChotthuocCollection FetchByID(object IdChot)
        {
            TLichsuChotthuocCollection coll = new TLichsuChotthuocCollection().Where("id_chot", IdChot).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TLichsuChotthuocCollection FetchByQuery(Query qry)
        {
            TLichsuChotthuocCollection coll = new TLichsuChotthuocCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdChot)
        {
            return (TLichsuChotthuoc.Delete(IdChot) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdChot)
        {
            return (TLichsuChotthuoc.Destroy(IdChot) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime NgayChot,string NguoiChot,byte? Noitru)
	    {
		    TLichsuChotthuoc item = new TLichsuChotthuoc();
		    
            item.NgayChot = NgayChot;
            
            item.NguoiChot = NguoiChot;
            
            item.Noitru = Noitru;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdChot,DateTime NgayChot,string NguoiChot,byte? Noitru)
	    {
		    TLichsuChotthuoc item = new TLichsuChotthuoc();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdChot = IdChot;
				
			item.NgayChot = NgayChot;
				
			item.NguoiChot = NguoiChot;
				
			item.Noitru = Noitru;
				
	        item.Save(UserName);
	    }
    }
}
