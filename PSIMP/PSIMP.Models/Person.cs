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
    
    public partial class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Height { get; set; }
        public string Census { get; set; }
        public string IDCard { get; set; }
        public Nullable<int> Age { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public byte[] Picture { get; set; }
    }
}
