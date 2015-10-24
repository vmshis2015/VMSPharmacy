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
    /// Controller class for Sys_RolesForUsers
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SysRolesForUserController
    {
        // Preload our schema..
        SysRolesForUser thisSchemaLoad = new SysRolesForUser();
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
        public SysRolesForUserCollection FetchAll()
        {
            SysRolesForUserCollection coll = new SysRolesForUserCollection();
            Query qry = new Query(SysRolesForUser.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysRolesForUserCollection FetchByID(object SUID)
        {
            SysRolesForUserCollection coll = new SysRolesForUserCollection().Where("sUID", SUID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysRolesForUserCollection FetchByQuery(Query qry)
        {
            SysRolesForUserCollection coll = new SysRolesForUserCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object SUID)
        {
            return (SysRolesForUser.Delete(SUID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object SUID)
        {
            return (SysRolesForUser.Destroy(SUID) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(string SUID,long IRoleID,long IParentRoleID,string FpSBranchID)
        {
            Query qry = new Query(SysRolesForUser.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("SUID", SUID).AND("IRoleID", IRoleID).AND("IParentRoleID", IParentRoleID).AND("FpSBranchID", FpSBranchID);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string SUID,long IRoleID,long IParentRoleID,string FpSBranchID)
	    {
		    SysRolesForUser item = new SysRolesForUser();
		    
            item.SUID = SUID;
            
            item.IRoleID = IRoleID;
            
            item.IParentRoleID = IParentRoleID;
            
            item.FpSBranchID = FpSBranchID;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string SUID,long IRoleID,long IParentRoleID,string FpSBranchID)
	    {
		    SysRolesForUser item = new SysRolesForUser();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.SUID = SUID;
				
			item.IRoleID = IRoleID;
				
			item.IParentRoleID = IParentRoleID;
				
			item.FpSBranchID = FpSBranchID;
				
	        item.Save(UserName);
	    }
    }
}
