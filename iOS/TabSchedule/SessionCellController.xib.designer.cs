// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monospace11 {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("SessionCellController")]
	public partial class SessionCellController {
		
		private MonoTouch.UIKit.UILabel __mt_labelTime;
		
		private MonoTouch.UIKit.UILabel __mt_labelTitle;
		
		private MonoTouch.UIKit.UILabel __mt_labelSubtitle;
		
		private MonoTouch.UIKit.UITableViewCell __mt_cell;
		
		private MonoTouch.UIKit.UILabel __mt_labelTimeEnd;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("labelTime")]
		private MonoTouch.UIKit.UILabel labelTime {
			get {
				this.__mt_labelTime = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("labelTime")));
				return this.__mt_labelTime;
			}
			set {
				this.__mt_labelTime = value;
				this.SetNativeField("labelTime", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("labelTitle")]
		private MonoTouch.UIKit.UILabel labelTitle {
			get {
				this.__mt_labelTitle = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("labelTitle")));
				return this.__mt_labelTitle;
			}
			set {
				this.__mt_labelTitle = value;
				this.SetNativeField("labelTitle", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("labelSubtitle")]
		private MonoTouch.UIKit.UILabel labelSubtitle {
			get {
				this.__mt_labelSubtitle = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("labelSubtitle")));
				return this.__mt_labelSubtitle;
			}
			set {
				this.__mt_labelSubtitle = value;
				this.SetNativeField("labelSubtitle", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("cell")]
		private MonoTouch.UIKit.UITableViewCell cell {
			get {
				this.__mt_cell = ((MonoTouch.UIKit.UITableViewCell)(this.GetNativeField("cell")));
				return this.__mt_cell;
			}
			set {
				this.__mt_cell = value;
				this.SetNativeField("cell", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("labelTimeEnd")]
		private MonoTouch.UIKit.UILabel labelTimeEnd {
			get {
				this.__mt_labelTimeEnd = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("labelTimeEnd")));
				return this.__mt_labelTimeEnd;
			}
			set {
				this.__mt_labelTimeEnd = value;
				this.SetNativeField("labelTimeEnd", value);
			}
		}
	}
}
