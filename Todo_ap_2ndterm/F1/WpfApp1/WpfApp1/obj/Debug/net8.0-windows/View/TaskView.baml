   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.TaskView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.View     5        � 	Resources  5	         RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius
 � Tag��%�   &	        �� 5
   
   " ��6+   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 40��6K   ._�5      �� #��z 6$   $
��Fill=�6C   5      5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � -   5         �Name$ todolistGrid��5      ���#777	 � RowDefinitions	 5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5%      �� $
��Auto��6   
 �� Orientation$
 
Horizontal=�6'   .+�5&      �� -   5        
��� � �$
��Auto��5&   J   $��10q�6W   .��5'      �� $��\Images\add.png��6   $��20��65   $��20��6A   5(      5)      �� 5+      -   5         ��Name$ todolistview��5+      $��1��5,      $��
10,0,10,10q�5-      ��5.      �� *OTodos+ �� SelectedItem 5/      �� *SelectedTodo+ �� Mode$ TwoWay=���51      �� 52      .R�53      �� $
 
Horizontal=�6%   $��Stretch=�6>   .+�54      �� $��Center=�6>   $��5q�6Y   $	��200��6d   ��6(   �� *Name+6d   �� 56       ��Name$ 	deletebtn��6%   -   5        
���  ��$	��1,0q�56   e    57       �� *Id+.��58   "   �� $��\Images\delete.png��6(   $��20��6D   $��20��6P   $
��Fill=�6[   59      �� 5<      $ editbtn��6%   -   5        
����  �$	��1,0q�5<   H    6o   �� .��5=   "   �� $��\Images\edit.png��6(   $��20��6B   $��20��6N   $
��Fill=�6Y   5>      5A      5B      5D      5E      �� 5G   
   -   5         ��Name$ Tododetails��5G      $��1��5H      $	��300��5I      $��10q�5J      $y�	Collapsed=�5K      .+�5L      �� $
 
Horizontal=�6   .+�5N      �� $��
20,0,160,0q�6   .��6(   Name:6/   �� 5O      .��6   	ListId:6!   5Q      �� 5S      $
 
Horizontal=�6   .+�5T      �� $��0,7,5,0q�6    d� 	IsChecked 6*   �� *SelectedTodo.Checked+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5U      �� 5W      $	��200��6   $��0,7,0,0q�6#   ��64   �� *SelectedTodo.Name+$ TwoWay=�$ PropertyChanged=��� 5X      $��18��6   $��8,7,0,0q�6&   $��40��67   ��6B   �� *SelectedTodo.ListId+$ TwoWay=�$ PropertyChanged=�.��6�   5Y      5Z      �� 5\      .��6   	Due Date:6   (  "System.Windows.Controls.DatePicker  5]      $
��Left=�5^      $��Center=�5_         SelectedDate 5]      �� *SelectedTodo.DueDate+$ TwoWay=�$ PropertyChanged=�5_      5b      5c      5d      