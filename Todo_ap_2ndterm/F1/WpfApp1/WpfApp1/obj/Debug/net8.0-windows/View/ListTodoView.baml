   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.ListTodoView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.View     5      .��5
      � 
���P��  � ColumnDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ todolistview��5      
���P��$
��Auto��5      $��1��5       �� DisplayMemberPath$
 Name��5      ��5      �� *
OTodoLists+ �� SelectedItem 5      �� *SelectedTodoList+ �� Mode$ TwoWay=���5      �� 5      .R�5       ��  �� Orientation$ 
Horizontal=�6!   5!      5#      �� 5)   
   -   5        
��� � �$
��Auto��5)   $   $��4q�61   $��Right=�6[   $��1��6x   .��5*      �� $��\Images\add.png��6   $��20��62   $��20��6>   5+      �� 5-   
   -   5         ��Name$ 
deletelist��5-      $
��Auto��6%   $��4q�62   $��Right=�6�   $��2��6�   
 � Tag 6>   �� *SelectedTodoList.Id+.��5.      �� $��\Images\delete.png��6   $��20��60   $��20��6<   $
��Fill=�6G   5/      52      53      