/*<copyright>
Mo+ Solution Builder is a model oriented programming language and IDE, used for building models and generating code and other documents in a model driven development process.

Copyright (C) 2013 Dave Clemmer, Intelligent Coding Solutions, LLC

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.
</copyright>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using MoPlus.Data;
using MoPlus.Interpreter;
using MoPlus.Interpreter.BLL.Config;
using MoPlus.Interpreter.BLL.Diagrams;
using MoPlus.Interpreter.BLL.Entities;
using MoPlus.Interpreter.BLL.Interpreter;
using MoPlus.Interpreter.BLL.Models;
using MoPlus.Interpreter.BLL.Solutions;
using MoPlus.Interpreter.BLL.Specifications;
using MoPlus.Interpreter.BLL.Workflows;
using MoPlus.ViewModel.Messaging;
using MoPlus.ViewModel.Resources;
using MoPlus.ViewModel.Events;
using MoPlus.ViewModel.Events.Diagrams;
using MoPlus.ViewModel.Diagrams;
using MoPlus.ViewModel.Events.Entities;
using MoPlus.ViewModel.Entities;
using MoPlus.ViewModel.Events.Interpreter;
using MoPlus.ViewModel.Interpreter;
using MoPlus.ViewModel.Events.Models;
using MoPlus.ViewModel.Models;
using MoPlus.ViewModel.Events.Solutions;
using MoPlus.ViewModel.Solutions;
using MoPlus.ViewModel.Events.Workflows;
using MoPlus.ViewModel.Workflows;

namespace MoPlus.ViewModel.Solutions
{
	///--------------------------------------------------------------------------------
	/// <summary>This class provides views for ViewProperty instances.</summary>
	///
	/// This file is code generated and should not be modified by hand.
	/// If you need to customize this file outside of protected areas,
	/// change the Status value below to something other than
	/// Generated to prevent changes from being overwritten.
	///
	/// <CreatedByUserName>INCODE-1\Dave</CreatedByUserName>
	/// <CreatedDate>1/26/2017</CreatedDate>
	/// <Status>Generated</Status>
	///--------------------------------------------------------------------------------
	public partial class ViewPropertyViewModel : DialogEditWorkspaceViewModel
	{
		#region "Menus"
		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabelNewViewProperty.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelNewViewProperty
		{
			get
			{
				return DisplayValues.ContextMenu_NewViewProperty;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabeNewlViewPropertyToolTip.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelViewPropertyToolTip
		{
			get
			{
				return DisplayValues.ContextMenu_NewViewPropertyToolTip;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabelEdit.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelEdit
		{
			get
			{
				return DisplayValues.ContextMenu_Edit;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabelEditToolTip.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelEditToolTip
		{
			get
			{
				return DisplayValues.ContextMenu_EditToolTip;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabelDelete.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelDelete
		{
			get
			{
				return DisplayValues.ContextMenu_Delete;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets MenuLabelDeleteToolTip.</summary>
		///--------------------------------------------------------------------------------
		public string MenuLabelDeleteToolTip
		{
			get
			{
				return DisplayValues.ContextMenu_DeleteToolTip;
			}
		}

		#endregion "Menus"

		#region "Editing Support"
		///--------------------------------------------------------------------------------
		/// <summary>This property gets IsEdited.</summary>
		///--------------------------------------------------------------------------------
		public override bool IsEdited
		{
			get
			{
				if (EditViewProperty.IsModified == true)
				{
					return true;
				}
				if (ItemsToAdd.Count > 0)
				{
					return true;
				}
				if (ItemsToDelete.Count > 0)
				{
					return true;
				}
				foreach (IEditWorkspaceViewModel item in Items)
				{
					if (item.IsEdited == true)
					{
						return true;
					}
				}
				return false;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets IsEditItemValid.</summary>
		///--------------------------------------------------------------------------------
		public override bool IsEditItemValid
		{
			get
			{
				return string.IsNullOrEmpty(PropertyIDValidationMessage + OrderValidationMessage + DescriptionValidationMessage);
			}
		}
 
		private ViewProperty _editViewProperty = null;
		///--------------------------------------------------------------------------------
		/// <summary>This property gets or sets EditViewProperty.</summary>
		///--------------------------------------------------------------------------------
		public ViewProperty EditViewProperty
		{
			get
			{
				if (_editViewProperty == null)
				{
					_editViewProperty = new ViewProperty();
					_editViewProperty.PropertyChanged += new PropertyChangedEventHandler(EditViewProperty_PropertyChanged);
					Items.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Children_CollectionChanged);
					if (ViewProperty != null)
					{
						_editViewProperty.TransformDataFromObject(ViewProperty, null, false);
						_editViewProperty.Solution = ViewProperty.Solution;
						_editViewProperty.Property = ViewProperty.Property;
						_editViewProperty.View = ViewProperty.View;
					}
					_editViewProperty.ResetModified(false);
				}
				return _editViewProperty;
			}
			set
			{
				_editViewProperty = value;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method sets view model property changes upon property change of
		/// the edit entity.</summary>
		///--------------------------------------------------------------------------------
		void EditViewProperty_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			OnPropertyChanged("EditViewProperty");
			OnPropertyChanged("TabTitle");
			
			OnPropertyChanged("PropertyID");
			OnPropertyChanged("PropertyIDCustomized");
			OnPropertyChanged("PropertyIDValidationMessage");
			
			OnPropertyChanged("Order");
			OnPropertyChanged("OrderCustomized");
			OnPropertyChanged("OrderValidationMessage");
			
			OnPropertyChanged("Description");
			OnPropertyChanged("DescriptionCustomized");
			OnPropertyChanged("DescriptionValidationMessage");

			OnPropertyChanged("Tags");
			OnPropertyChanged("TagsCustomized");
			OnPropertyChanged("TagsValidationMessage");
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets Title.</summary>
		///--------------------------------------------------------------------------------
		public string Title
		{
			get
			{
				return DisplayValues.Edit_ViewPropertyHeader;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets TabTitle.</summary>
		///--------------------------------------------------------------------------------
		public override string TabTitle
		{
			get
			{
				return DisplayValues.Edit_ViewPropertyHeader + " (" + EditName + ")";
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets the ViewPropertyIDLabel.</summary>
		///--------------------------------------------------------------------------------
		public string ViewPropertyIDLabel
		{
			get
			{
				return DisplayValues.Edit_ViewPropertyIDProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets the PropertyIDLabel.</summary>
		///--------------------------------------------------------------------------------
		public string PropertyIDLabel
		{
			get
			{
				return DisplayValues.Edit_PropertyIDSelection + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets PropertyID.</summary>
		///--------------------------------------------------------------------------------
		public Guid PropertyID
		{
			get
			{
				return EditViewProperty.PropertyID;
			}
			set
			{
				EditViewProperty.PropertyID = value;
				OnPropertyChanged("PropertyID");
				OnPropertyChanged("TabTitle");
			}
		}
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets PropertyIDCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool PropertyIDCustomized
		{
			get
			{
				if (ViewProperty.ReverseInstance != null)
				{
					return PropertyID.GetGuid() != ViewProperty.ReverseInstance.PropertyID.GetGuid();
				}
				else if (ViewProperty.IsAutoUpdated == true)
				{
					return PropertyID.GetGuid() != ViewProperty.PropertyID.GetGuid();
				}
				return PropertyID != DefaultValue.Guid;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets PropertyIDValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string PropertyIDValidationMessage
		{
			get
			{
				return EditViewProperty.ValidatePropertyID();
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets the OrderLabel.</summary>
		///--------------------------------------------------------------------------------
		public string OrderLabel
		{
			get
			{
				return DisplayValues.Edit_OrderProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets Order.</summary>
		///--------------------------------------------------------------------------------
		public int Order
		{
			get
			{
				return EditViewProperty.Order;
			}
			set
			{
				EditViewProperty.Order = value;
				OnPropertyChanged("Order");
				OnPropertyChanged("TabTitle");
			}
		}
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets OrderCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool OrderCustomized
		{
			get
			{
				if (ViewProperty.ReverseInstance != null)
				{
					return Order.GetInt() != ViewProperty.ReverseInstance.Order.GetInt();
				}
				else if (ViewProperty.IsAutoUpdated == true)
				{
					return Order.GetInt() != ViewProperty.Order.GetInt();
				}
				return Order != DefaultValue.Int;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets OrderValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string OrderValidationMessage
		{
			get
			{
				return EditViewProperty.ValidateOrder();
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets the DescriptionLabel.</summary>
		///--------------------------------------------------------------------------------
		public string DescriptionLabel
		{
			get
			{
				return DisplayValues.Edit_DescriptionProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets Description.</summary>
		///--------------------------------------------------------------------------------
		public string Description
		{
			get
			{
				return EditViewProperty.Description;
			}
			set
			{
				EditViewProperty.Description = value;
				OnPropertyChanged("Description");
				OnPropertyChanged("TabTitle");
			}
		}
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets DescriptionCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool DescriptionCustomized
		{
			get
			{
				if (ViewProperty.ReverseInstance != null)
				{
					return Description.GetString() != ViewProperty.ReverseInstance.Description.GetString();
				}
				else if (ViewProperty.IsAutoUpdated == true)
				{
					return Description.GetString() != ViewProperty.Description.GetString();
				}
				return Description != DefaultValue.String;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets DescriptionValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string DescriptionValidationMessage
		{
			get
			{
				return EditViewProperty.ValidateDescription();
			}
		}
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets SourceNameLabel.</summary>
		///--------------------------------------------------------------------------------
		public string SourceNameLabel
		{
			get
			{
				return DisplayValues.Edit_SourceNameProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets the SourceName.</summary>
		///--------------------------------------------------------------------------------
		public override string SourceName
		{
			get
			{
				return EditViewProperty.SourceName;
			}
			set
			{
				EditViewProperty.SourceName = value;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SourceNameCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool SourceNameCustomized
		{
			get
			{
				return false;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SourceNameVisibility.</summary>
		///--------------------------------------------------------------------------------
		public string SourceNameVisibility
		{
			get
			{
				if (String.IsNullOrEmpty(SourceName))
				{
					return "Collapsed";
				}
				return "Visible";
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SourceNameValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string SourceNameValidationMessage
		{
			get
			{
				return String.Empty;
			}
		}
		
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets SpecSourceNameLabel.</summary>
		///--------------------------------------------------------------------------------
		public string SpecSourceNameLabel
		{
			get
			{
				return DisplayValues.Edit_SpecSourceNameProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets the SpecSourceName.</summary>
		///--------------------------------------------------------------------------------
		public override string SpecSourceName
		{
			get
			{
				return EditViewProperty.SpecSourceName;
			}
			set
			{
				EditViewProperty.SpecSourceName = value;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SpecSourceNameCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool SpecSourceNameCustomized
		{
			get
			{
				return false;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SpecSourceNameVisibility.</summary>
		///--------------------------------------------------------------------------------
		public string SpecSourceNameVisibility
		{
			get
			{
				if (String.IsNullOrEmpty(SpecSourceName))
				{
					return "Collapsed";
				}
				return "Visible";
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets SpecSourceNameValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string SpecSourceNameValidationMessage
		{
			get
			{
				return String.Empty;
			}
		}
		
		///--------------------------------------------------------------------------------
		/// <summary>This property gets TagsLabel.</summary>
		///--------------------------------------------------------------------------------
		public string TagsLabel
		{
			get
			{
				return DisplayValues.Edit_TagsProperty + DisplayValues.Edit_LabelColon;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets/sets the Tags.</summary>
		///--------------------------------------------------------------------------------
		public override string Tags
		{
			get
			{
				return EditViewProperty.Tags;
			}
			set
			{
				EditViewProperty.Tags = value;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets TagsCustomized.</summary>
		///--------------------------------------------------------------------------------
		public bool TagsCustomized
		{
			get
			{
				if (ViewProperty.ReverseInstance != null)
				{
					return Tags != ViewProperty.ReverseInstance.Tags;
				}
				else if (ViewProperty.IsAutoUpdated == true)
				{
					return Tags != ViewProperty.Tags;
				}
				return Tags != DefaultValue.String;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets TagsValidationMessage.</summary>
		///--------------------------------------------------------------------------------
		public string TagsValidationMessage
		{
			get
			{
				return EditViewProperty.ValidateTags();
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets or sets EditName.</summary>
		///--------------------------------------------------------------------------------
		public string EditName
		{
			get
			{
				return EditViewProperty.Name;
			}
			set
			{
				EditViewProperty.Name = value;
			}
		}
		
		#endregion "Editing Support"

		#region "Command Processing"
		///--------------------------------------------------------------------------------
		/// <summary>This method resets the data.</summary>
		///--------------------------------------------------------------------------------
		protected override void OnReset()
		{
			EditViewProperty.TransformDataFromObject(ViewProperty, null, false);
			EditViewProperty.ResetModified(false);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method resets the data.</summary>
		///--------------------------------------------------------------------------------
		public override void Reset()
		{
			OnReset();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method sets the default values.</summary>
		///--------------------------------------------------------------------------------
		protected override void OnSetDefaults()
		{
			if (ViewProperty.ReverseInstance != null)
			{
				EditViewProperty.TransformDataFromObject(ViewProperty.ReverseInstance, null, false);
			}
			else if (ViewProperty.IsAutoUpdated == true)
			{
				EditViewProperty.TransformDataFromObject(ViewProperty, null, false);
			}
			else
			{
				ViewProperty newViewProperty = new ViewProperty();
				newViewProperty.ViewPropertyID = EditViewProperty.ViewPropertyID;
				EditViewProperty.TransformDataFromObject(newViewProperty, null, false);
			}
			EditViewProperty.ResetModified(true);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method sets the default values.</summary>
		///--------------------------------------------------------------------------------
		public void Defaults()
		{
			OnSetDefaults();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method processes the new ViewProperty command.</summary>
		///--------------------------------------------------------------------------------
		public void ProcessNewViewPropertyCommand()
		{
			ViewPropertyEventArgs message = new ViewPropertyEventArgs();
			message.ViewProperty = new ViewProperty();
			message.ViewProperty.ViewPropertyID = Guid.NewGuid();
			message.ViewProperty.ViewID = ViewID;
			message.ViewProperty.View = Solution.ViewList.FindByID((Guid)ViewID);
			if (message.ViewProperty.View != null)
			{
				message.ViewProperty.Order = message.ViewProperty.View.ViewPropertyList.Count + 1;
			}
			message.ViewProperty.Solution = Solution;
			message.ViewID = ViewID;
			message.Solution = Solution;
			message.WorkspaceID = WorkspaceID;
			Mediator.NotifyColleagues<ViewPropertyEventArgs>(MediatorMessages.Command_EditViewPropertyRequested, message);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method processes the edit item command.</summary>
		///--------------------------------------------------------------------------------
		public void ProcessEditViewPropertyCommand()
		{
			ViewPropertyEventArgs message = new ViewPropertyEventArgs();
			message.ViewProperty = ViewProperty;
			message.ViewID = ViewID;
			message.Solution = Solution;
			message.WorkspaceID = WorkspaceID;
			Mediator.NotifyColleagues<ViewPropertyEventArgs>(MediatorMessages.Command_EditViewPropertyRequested, message);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method initiates editing a new item.</summary>
		///--------------------------------------------------------------------------------
		protected override void OnNew()
		{
			ProcessNewViewPropertyCommand();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method updates the view model data and sends update command back
		/// to the solution builder.</summary>
		///--------------------------------------------------------------------------------
		protected override void OnUpdate()
		{
			// set up reverse engineering instance if not present
			if (ViewProperty.ReverseInstance == null && ViewProperty.IsAutoUpdated == true)
			{
				ViewProperty.ReverseInstance = new ViewProperty();
				ViewProperty.ReverseInstance.TransformDataFromObject(ViewProperty, null, false);

				// perform the update of EditViewProperty back to ViewProperty
				ViewProperty.TransformDataFromObject(EditViewProperty, null, false);
				ViewProperty.IsAutoUpdated = false;
			}
			else if (ViewProperty.ReverseInstance != null)
			{
				EditViewProperty.ResetModified(ViewProperty.ReverseInstance.IsModified);
				if (EditViewProperty.Equals(ViewProperty.ReverseInstance))
				{
					// perform the update of EditViewProperty back to ViewProperty
					ViewProperty.TransformDataFromObject(EditViewProperty, null, false);
					ViewProperty.IsAutoUpdated = true;
				}
				else
				{
					// perform the update of EditViewProperty back to ViewProperty
					ViewProperty.TransformDataFromObject(EditViewProperty, null, false);
					ViewProperty.IsAutoUpdated = false;
				}
			}
			else
			{
				// perform the update of EditViewProperty back to ViewProperty
				ViewProperty.TransformDataFromObject(EditViewProperty, null, false);
				ViewProperty.IsAutoUpdated = false;
			}
			ViewProperty.ForwardInstance = null;
			if (PropertyIDCustomized || OrderCustomized || DescriptionCustomized || TagsCustomized)
			{
				ViewProperty.ForwardInstance = new ViewProperty();
				ViewProperty.ForwardInstance.ViewPropertyID = EditViewProperty.ViewPropertyID;
				ViewProperty.SpecSourceName = ViewProperty.DefaultSourceName;
				if (PropertyIDCustomized)
				{
					ViewProperty.ForwardInstance.PropertyID = EditViewProperty.PropertyID;
				}
				if (OrderCustomized)
				{
					ViewProperty.ForwardInstance.Order = EditViewProperty.Order;
				}
				if (DescriptionCustomized)
				{
					ViewProperty.ForwardInstance.Description = EditViewProperty.Description;
				}
				if (TagsCustomized)
				{
					ViewProperty.ForwardInstance.Tags = EditViewProperty.Tags;
				}
			}
			EditViewProperty.ResetModified(false);
			OnUpdated(this, null);

			// send update back to solution builder
			SendEditViewPropertyPerformed();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method updates the view model data and sends update command back
		/// to the solution builder.</summary>
		///--------------------------------------------------------------------------------
		public void Update()
		{
			OnUpdate();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method sends the edit item performed message to have the
		/// update applied.</summary>
		///--------------------------------------------------------------------------------
		public void SendEditViewPropertyPerformed()
		{
			ViewPropertyEventArgs message = new ViewPropertyEventArgs();
			message.ViewProperty = ViewProperty;
			message.ViewID = ViewID;
			message.Solution = Solution;
			message.WorkspaceID = WorkspaceID;
			Mediator.NotifyColleagues<ViewPropertyEventArgs>(MediatorMessages.Command_EditViewPropertyPerformed, message);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method processes the delete ViewProperty command.</summary>
		///--------------------------------------------------------------------------------
		public void ProcessDeleteViewPropertyCommand()
		{
			ViewPropertyEventArgs message = new ViewPropertyEventArgs();
			message.ViewProperty = ViewProperty;
			message.ViewID = ViewID;
			message.Solution = Solution;
			message.WorkspaceID = WorkspaceID;
			Mediator.NotifyColleagues<ViewPropertyEventArgs>(MediatorMessages.Command_DeleteViewPropertyRequested, message);
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method processes a delete of the item.</summary>
		///--------------------------------------------------------------------------------
		public void Delete()
		{
			ProcessDeleteViewPropertyCommand();
		}

		#endregion "Command Processing"

		#region "Properties"

		///--------------------------------------------------------------------------------
		/// <summary>This property gets or sets the ViewProperty.</summary>
		///--------------------------------------------------------------------------------
		public ViewProperty ViewProperty { get; set; }

		///--------------------------------------------------------------------------------
		/// <summary>This property gets ViewPropertyID.</summary>
		///--------------------------------------------------------------------------------
		public Guid ViewPropertyID
		{
			get
			{
				return ViewProperty.ViewPropertyID;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets or sets Name.</summary>
		///--------------------------------------------------------------------------------
		public override string Name
		{
			get
			{
				return ViewProperty.Name;
			}
			set
			{
				ViewProperty.Name = value;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets ItemOrder.</summary>
		///--------------------------------------------------------------------------------
		public int ItemOrder
		{
			get
			{
				return ViewProperty.Order;
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This property gets or sets ViewID.</summary>
		///--------------------------------------------------------------------------------
		public Guid ViewID
		{
			get
			{
				return ViewProperty.ViewID;
			}
			set
			{
				ViewProperty.ViewID = value;
			}
		}

		#endregion "Properties"

		#region "Methods"
		///--------------------------------------------------------------------------------
		/// <summary>This method loads an item of ViewProperty into the view model.</summary>
		/// 
		/// <param name="viewProperty">The ViewProperty to load.</param>
		/// <param name="loadChildren">Flag indicating whether to perform a deeper load.</param>
		///--------------------------------------------------------------------------------
		public void LoadViewProperty(ViewProperty viewProperty, bool loadChildren = true)
		{
			// attach the ViewProperty
			ViewProperty = viewProperty;
			ItemID = ViewProperty.ViewPropertyID;
			Items.Clear();
			if (loadChildren == true)
			{
				#region protected
				#endregion protected
				
				Refresh(false);
			}
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method refreshes the view model.</summary>
		/// 
		/// <param name="refreshChildren">Flag indicating whether children should be refreshed.</param>
		///--------------------------------------------------------------------------------
		public void Refresh(bool refreshChildren, int refreshLevel = 0)
		{
			if (refreshChildren == true || refreshLevel > 0)
			{
			}
			
			#region protected
			#endregion protected
			
			HasErrors = !ViewProperty.IsValid;
			HasCustomizations = ViewProperty.IsAutoUpdated == false || ViewProperty.IsEmptyMetadata(ViewProperty.ForwardInstance) == false || ChildrenHaveAnyCustomizations();
			if (HasCustomizations == false && ViewProperty.ReverseInstance != null)
			{
				// remove customizations if solely due to child customizations no longer present
				ViewProperty.IsAutoUpdated = true;
				ViewProperty.SpecSourceName = ViewProperty.ReverseInstance.SpecSourceName;
				ViewProperty.ResetModified(ViewProperty.ReverseInstance.IsModified);
				ViewProperty.ResetLoaded(ViewProperty.ReverseInstance.IsLoaded);
				if (!ViewProperty.IsIdenticalMetadata(ViewProperty.ReverseInstance))
				{
					HasCustomizations = true;
					ViewProperty.IsAutoUpdated = false;
				}
			}
			if (HasCustomizations == false)
			{
				// clear customizations
				ViewProperty.ForwardInstance = null;
				ViewProperty.ReverseInstance = null;
				ViewProperty.IsAutoUpdated = true;
			}
			OnPropertyChanged("Items");
			OnPropertyChanged("HasCustomizations");
			OnPropertyChanged("HasErrors");
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method disposes of resources in the view model.</summary>
		///--------------------------------------------------------------------------------
		protected override void OnDispose()
		{
			if (_editViewProperty != null)
			{
				Items.CollectionChanged -= Children_CollectionChanged;
				EditViewProperty.PropertyChanged -= EditViewProperty_PropertyChanged;
				EditViewProperty = null;
			}
			ViewProperty = null;
			base.OnDispose();
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method returns whether or not the method or its children have any customizations.</summary>
		///--------------------------------------------------------------------------------
		public bool ChildrenHaveAnyCustomizations()
		{
			return false;
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method manages the update of this view when children are updated.</summary>
		/// 
		/// <param name="sender">The sender of the updated event.</param>
		/// <param name="e">The event arguments.</param>
		///--------------------------------------------------------------------------------
		private void Children_Updated(object sender, EventArgs e)
		{
			Refresh(false, 1);
			OnUpdated(this, e);
		}
	
		///--------------------------------------------------------------------------------
		/// <summary>This method manages when changes occur to child collections.</summary>
		/// 
		/// <param name="sender">The sender of the updated event.</param>
		/// <param name="e">The event arguments.</param>
		///--------------------------------------------------------------------------------
		private void Children_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
		}

		///--------------------------------------------------------------------------------
		/// <summary>This method returns the parent view model corresponding to
		/// the input message.</summary>
		///
		/// <param name="data">The message data to find parent for.</param>
		///--------------------------------------------------------------------------------
		public EditWorkspaceViewModel FindParentViewModel(SolutionModelEventArgs data)
		{
			#region protected
			#endregion protected
		
			return null;
		}
		#endregion "Methods"

		#region "Constructors"

		///--------------------------------------------------------------------------------
		/// <summary>The default constructor (for reflection, etc.).</summary>
		///--------------------------------------------------------------------------------
		public ViewPropertyViewModel()
		{
			WorkspaceID = Guid.NewGuid();
		}

		///--------------------------------------------------------------------------------
		/// <summary>Create the instance with the designer view and other data.</summary>
		/// 
		/// <param name="viewProperty">The ViewProperty to load.</param>
		/// <param name="solution">The associated solution.</param>
		/// <param name="loadChildren">Flag indicating if child information should be loaded.</param>
		///--------------------------------------------------------------------------------
		public ViewPropertyViewModel(ViewProperty viewProperty, Solution solution, bool loadChildren = true)
		{
			WorkspaceID = Guid.NewGuid();
			Solution = solution;
			LoadViewProperty(viewProperty, loadChildren);
		}

		#endregion "Constructors"
	}
}
