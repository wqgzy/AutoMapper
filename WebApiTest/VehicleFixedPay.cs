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
    
    public partial class VehicleFixedPay
    {
        public int VehicleID { get; set; }
        public int StaffID { get; set; }
        public Nullable<int> PayCurrency { get; set; }
        public string InsurancePayInfo { get; set; }
        public string TrafficForcePayInfo { get; set; }
        public string VehicleShipPayInfo { get; set; }
        public string OtherPayInfo { get; set; }
        public string OtherPayDesc { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<System.DateTime> PayCheckDate { get; set; }
        public Nullable<System.DateTime> NextPayDate { get; set; }
        public int PayState { get; set; }
        public string PayDescription { get; set; }
        public Nullable<System.DateTime> RemindOperateTime { get; set; }
    }
}
