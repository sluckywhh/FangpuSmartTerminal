//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace fangpu_terminal
{
    using System;
    using System.Collections.Generic;
    
    public partial class dailychecklist
    {
        public int idchecklist { get; set; }
        public string deviceid { get; set; }
        public string procedure { get; set; }
        public string name { get; set; }
        public string shift { get; set; }
        public Nullable<System.DateTime> checkdate { get; set; }
        public Nullable<bool> airpressure_check { get; set; }
        public Nullable<bool> gaspressure_check { get; set; }
        public Nullable<bool> airleak_check { get; set; }
        public Nullable<bool> gasleak_check { get; set; }
        public Nullable<bool> belt_check { get; set; }
        public Nullable<bool> furnacecylinder_check { get; set; }
        public Nullable<bool> surfacesensor_check { get; set; }
        public Nullable<bool> demouldcylinder_check { get; set; }
        public Nullable<bool> airtap_check { get; set; }
        public Nullable<bool> ventilator_check { get; set; }
        public Nullable<bool> screen_check { get; set; }
        public Nullable<bool> groundclean_check { get; set; }
        public Nullable<bool> tableclean_check { get; set; }
        public Nullable<float> normal { get; set; }
        public Nullable<float> debug { get; set; }
        public Nullable<float> tempup { get; set; }
        public Nullable<float> cleanmould { get; set; }
        public Nullable<float> changemoud { get; set; }
        public Nullable<float> changematerial { get; set; }
        public Nullable<float> device_error { get; set; }
        public Nullable<float> wait { get; set; }
        public Nullable<float> @else { get; set; }
        public string tablename { get; set; }
    }
}