   M S B A M L   `   `   `  ����F  BMVVMExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MVVMExample.ViewMVVMExample.View  5      !    MVVMExample.View.DetailView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MVVMExample.View     5      $	��200��5   7   .��5
      ��   �� Orientation$  Vertical=�6   
�������.+�5      �� -   5         ��Name$ ComboBox��5      $	��100��6   $��30��6+    �� SelectedIndex$ 0��6�   ��67   �� *
AllHoles+ �� SelectedItem 6X   �� *CurrentHole+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �� $  
Horizontal=�6   .+�5      �� ��6   �� *
NumeroID+ �� StringFormat$ 	Id: {0:0}��5      5      5      �� 5      $  Vertical=�6   $	��0,5q�6&    � DataContext 63   ��  �� ElementName$ ComboBox�� �� Path$ SelectedItem�$ PropertyChanged=�.+�5      �� $  
Horizontal=�6   $��Center=�6)   .+�5      �� $��Length:��6   $��Right=�6   $��5q�6;   �� 5      $
��Left=�6(   $��5q�6C   ��6   �� *Length+6C   5      �� 5      $  
Horizontal=�6   $��Center=�6)   .+�5      �� $��	Stemming:��6   $��Right=�6!   $��5q�6=   �� 5      $
��Left=�6*   $��5q�6E   ��6   �� *
Stemming+6E   5      �� 5      $  
Horizontal=�6   $��Center=�6)   .+�5      �� $��Total hole width:��6   $��Right=�6)   $��5q�6E   �� 5      $
��Left=�60   $��5q�6K   ��6   �� *HoleWidthTotal+6K   5       5!      5"      5#      