   M S B A M L   `   `   `  ����E  ADoctorList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DoctorList
DoctorList  5          DoctorList.DoctorListUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DoctorList     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  5	      -   5        $��ucDoctorList��5         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        DoctorListVM � DataContext# [ 5      .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid��5         CanUserAddRows .     AutoGenerateColumns .     HeadersVisibility$	 All=�5      ��5      �� *	Doctors+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header
 5      �� 5      -   5        $��	AllSelect��5   #    d� IsThreeState .  d� 	IsChecked 5   #   ��  �� RelativeSource ��  �� AncestorType$ UserControlL� �� Path$ DataContext.IsCheckedAll�$ PropertyChanged=�.  (System.Windows.Interactivity.Interaction   Triggers 5!      /  )System.Windows.Interactivity.EventTrigger  5"   "      	EventName$ Click��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 5#   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6<   ��  �� $ ItemsControlL�$# DataContext.AllCheckedCommand�   CommandParameter 5$   <   ��  �� ElementName$ 	AllSelect��5%   #   5'         CellTemplate 5)      �� 5*      .R�5+      �� $	��abc��5,   j   $��asdasd��6P    5+   '   �� *	IsChecked+$ TwoWay=�$ PropertyChanged=���5,   '   �� *SingleCheckedCommand+ 5-   "     5.   &   $ Checked��65   . 5/   *      6@   ��  �� $ DataGridL�$&  DataContext.SingleCheckedCommand� 50   <   �� $	 abc��51   '     52   &   $ 	Unchecked��65   . 53   *      6@   ��  �� $ DataGridL�$&  DataContext.SingleCheckedCommand� 54   <   �� $	 abc��55   '   57      58      5:      0	  *System.Windows.Controls.DataGridTextColumn	  5<      $
 ID��5=   %    ) %MaterialDesignDataGridTextColumnStyle1
  +System.Windows.Controls.DataGridBoundColumn 
  ElementStyle# [ 5>   %    0 ,MaterialDesignDataGridTextColumnEditingStyle 
  EditingElementStyle# [ 5?   %    
  Binding 5<   %   �� *ID+5?   %   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5@      $
 Tên bác sĩ��64      Width5  /System.Windows.Controls.DataGridLengthConverter$	 160 5A   4   # [ 5B   4    5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5C   4    5D      �� 5E      $
 Name�6"   5G        5H      $
 Giới tính��64   $ 90 5I   4   # [ 5J   4   # [ 5K   4    5L      �� 5M      $	 Sex�6"   5O      	  5P      $
 Tuổi��6%   # [ 5Q   %   # [ 5R   %    5S      �� 5T      $	 Age�6"   5V        5W      $
 Số điện thoại��5X   4   $	 120 5Y   4   # [ 5Z   4    5W   4   �� *Phone+   HeaderStyle 5[      �� 5\       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6     & "MaterialDesignDataGridColumnHeader �� BasedOn# [ 5]       .�5^      ��  �� Property � �� �� Value$
 Left=�6K   �� 5_       � �� 5`   "   �� 5a   &   .R�5b   *   �� $
��Wrap=�64     �� TextAlignment$
  Left=�6Y   ��6H   �� 6Y   5c   '   5e      5f       5h      �� 5i      " ��6    # [ 6@   .�5j      ��  � ��$
 Left=�6D   5k      5m        5n      $
 Email��5o   4   $	 200 5p   4   # [ 5q   4    5n   4   �� *Mail+ 5r      �� 5s      "  6    # [ 5t       .�5u      ��  � ��$
 Left=�6K   �� 5v       � �� 5w   "   �� 5x   &   .R�5y   *   �� $
��Wrap=�64   $
  Left=�6Y   ��6H   �� 6Y   5z   '   5|      5}       5      �� 5�      " ��6    # [ 6@   .�5�      ��  � ��$
 Left=�6D   5�      5�        5�      $
 
Ngày sinh��5�   4   $	 200 5�   4   # [ 5�   4    5�   4   �� *
Birthday+ 5�      �� 5�      "  6    # [ 5�       .�5�      ��  � ��$
 Left=�6K   �� 5�       � �� 5�   "   �� 5�   &   .R�5�   *   �� $
��Wrap=�64   $
  Left=�6Y   ��6H   �� 6Y   5�   '   5�      5�       5�      �� 5�      " ��6    # [ 6@   .�5�      ��  � ��$
 Left=�6D   5�      5�      5�      5�      5�      