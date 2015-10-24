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
    /// Controller class for Sys_ImgAndIcon
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SysImgAndIconController
    {
        // Preload our schema..
        SysImgAndIcon thisSchemaLoad = new SysImgAndIcon();
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
        public SysImgAndIconCollection FetchAll()
        {
            SysImgAndIconCollection coll = new SysImgAndIconCollection();
            Query qry = new Query(SysImgAndIcon.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysImgAndIconCollection FetchByID(object Id)
        {
            SysImgAndIconCollection coll = new SysImgAndIconCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysImgAndIconCollection FetchByQuery(Query qry)
        {
            SysImgAndIconCollection coll = new SysImgAndIconCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (SysImgAndIcon.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (SysImgAndIcon.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string SFileName,string SFilePath,byte[] Data)
	    {
		    SysImgAndIcon item = new SysImgAndIcon();
		    
            item.SFileName = SFileName;
            
            item.SFilePath = SFilePath;
            
            item.Data = Data;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string SFileName,string SFilePath,byte[] Data)
	    {
		    SysImgAndIcon item = new SysImgAndIcon();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.SFileName = SFileName;
				
			item.SFilePath = SFilePath;
				
			item.Data = Data;
				
	        item.Save(UserName);
	    }
    }
}
