   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.ListTodoView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.View     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6&   �� 5      $
��Auto �6'   �� 5      $��* �6(   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   
����p��$
��Auto��5      $��0��5      .+�5      �� -   5         ��Name$ listview��5      
����p�� �� DisplayMemberPath$
 Name��5      ��5      �� *
OTodoLists+ �� SelectedItem 5      �� *SelectedTodoList+ �� Mode$ TwoWay=���5      �� 5      .R�5       �� $ 
Horizontal=�6!   5!      5#      �� 5&   
   -   5         ��Name$ editlistbtn��5&      
����  �$
��Auto��6[   $��4q�6h   $��3��6�   
 � Tag 6'   �� *SelectedTodoList+.��5'      �� $��\Images\edit.png��6   $��20��6.   $��20��6:   $
��Fill=�6E   5(      �� 5)   
   -   5        $
��Auto��5)      
����p��$��4q�68   $��Right=�6b   $��1��6   .��5*      �� $��\Images\add2.png��6   $��20��63   $��20��6?   5+      �� 5-      -   5        $ 
deletelist��5-      $
��Auto��6)   $��4q�66   $��Right=�6�   $��2��6�    6B   �� *SelectedTodoList.Id+.��5.      �� $��\Images\delete.png��6   $��20��64   $��20��6@   $
��Fill=�6K   5/      51      �� 55   
   $ 
Horizontal=�6   $��1��6/   ��56      �� 58       �� ImageSource$ \Images\lp2.png��6   .+�5?      �� -   5        $
��Auto��5?      $
��Auto��6�   $��8,5,5,5q�6�    6(   �� *SelectedTodoList.Id+	 �� UpdateSourceTrigger$	 PropertyChanged=�.��5@      �� $��\Images\add2.png��6   $��20��62   $��20��6>   5A      5C      � 5G   
   -   5        
 �Name$
 todolistGrid��5G      $��2��6    � ColumnDefinitions 5H      �� 5I      $
��Auto �6#   �� 5J      $
��Auto �6#   ��5N      �� 5O      $ \Images\sa.png��6   .+�5S      �� -   5        $ todolistview��5S      $��
10,2,10,10q�5T      $��2��5U      ��5W      �� *	OListPick+$	 PropertyChanged=� 5X      �� *SelectedTodo+$ TwoWay=�$	 PropertyChanged=���5[      �� 5\      $ \Images\lp2.png��6!   ��5_      �� 5`      .R�5a      �� $ 
Horizontal=�6%   $��Stretch=�6>   .+�5c      �� $��Center=�6>   $��5q�6Y   $	��200��6d   ��6(   �� *Name+6d   �� 5e      $ 	deletebtn��6%   -   5        
���  ��$	��1,0q�5e   e    5f   "   �� *Id+$	 PropertyChanged=�.��5g   "   �� $��\Images\delete.png��6(   $��20��6D   $��20��6P   $
��Fill=�6[   5h      �� 5j      $ editbtn��6%   -	   5        
����  �$	��1,0q�5j   H    6o   �� .��5k   "   �� $��\Images\edit.png��6(   $��20��6B   $��20��6N   $
��Fill=�6Y   5l      5m      5n      5p      �� 5s      -
   5         ��Name$ Tododetails��5s      $��1��5t      $��2��5u      $	��300��5v      $��10q�5w      $y�	Collapsed=�5x      .+�5z      �� $ 
Horizontal=�6   .+�5{      �� $��
20,0,160,0q�6   .��60   Name:67   �� 5|      .��6   	ListName:6'   5}      �� 5      $ 
Horizontal=�6   .+�5�      �� $��0,7,5,0q�6    d� 	IsChecked 60   �� *SelectedTodo.Checked+$ TwoWay=�$	 PropertyChanged=��� 5�      $	��200��6   $��0,7,0,0q�6*   ��6;   �� *SelectedTodo.Name+$ TwoWay=�$	 PropertyChanged=��� 5�      $	��200��6   $��8,7,0,0q�6*   ��6;   �� *Todo2.ListName+$ TwoWay=�$	 PropertyChanged=�5�      �� 5�      .��6   	Due Date:6#   (  "System.Windows.Controls.DatePicker  5�      $
��Left=�5�      $��Center=�5�         SelectedDate 5�      �� *SelectedTodo.DueDate+$ TwoWay=�$	 PropertyChanged=�5�      5�      5�      5�      5�      