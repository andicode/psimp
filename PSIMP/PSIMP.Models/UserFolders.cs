//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace PSIMP.Models
{
	using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class UserFolders
    {
        public UserFolders()
        {
            this.UserFiles = new HashSet<UserFiles>();
        }
    
        public System.Guid ID { get; set; }
        public string FolderName { get; set; }
        public int UserId { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<UserFiles> UserFiles { get; set; }
    }
}
