//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffWorkInfo
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public Nullable<int> WorkAge { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> PositionID { get; set; }
        public Nullable<int> UpLevelStaffID { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
        public Nullable<System.DateTime> DepartureTime { get; set; }
        public Nullable<int> InJobState { get; set; }
        public string Description { get; set; }
        public Nullable<int> Station { get; set; }
    }
}
