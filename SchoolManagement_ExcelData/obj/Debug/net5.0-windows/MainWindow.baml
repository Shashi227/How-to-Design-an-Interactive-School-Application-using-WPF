   M S B A M L   `   `   `  ����  SchoolManagement_ExcelData+    %SchoolManagement_ExcelData.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Manage Excel Data��5   	   $	��425��6#   $
��1080��60   
����� � � 
ResizeMode$ NoResize=�5   2   .��5      �� .+�5	   
   � $��77��6   $	��Top=�6   ���	#FF4572A0.+�5
      �� $
��Left=�6   $��74��6/   $��	113,0,0,0q�6;   $	��Top=�6N   $	��882��6f   $��/LKSNNAME.jpeg��6r   $
��Fill=�6�   �� 5      $
��Left=�6B   $
��10 0q�6]   ��6   Z� ��6+   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6*   $��25��66   $��25��6A   5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10 0q�6N   .+�5      �� ��6   Z� ��6/   Z� .��5        $ Account=�6.   5      �� 5      ��6   Z� ��6/   Z� .��5        $ Power=�6.   5      5      5      � 5   
   $	��325��6    � RowDefinitions 5      �� 5      $	��40* �6    �� 5      $
��202* �6     J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 0Q�6#      ShadowDepth$ 2Q�62   .+�5!      �� -   5        $��btnRefreshRecord��5"      $��Save Record��5!      $��0��5"   )   $
��Bold"�67   
���  ��$��16(�5#      $��885,1,26,10q�6>   $��Italic$�6S   &   System.Windows.Controls.DataGrid  5$      -   5        $��dataGridStudent��5$         AutoGenerateColumns$ False��6.   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6J   
   RowBackground

 �����
����ح�$��0,1,0,91q�5&   _   $��1��6q      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Student ID��6)      Width$ 70 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *	StudentID+6h     5)      $
 Name��6)    67   �� *Name+6R     5*      $ Email��6)   $	 140 6R    68   �� *Email+6`     5+      $ Class��6)   $ 80 6R    68   �� *Class+6_     5,      $ Address��6)   $	 120 6V    6:   �� *	Address+6d     5-      $	 Dob��6)   $	 100 6N    66   �� *Dob+6\     5.      $ PhoneNo��6)   $	 170 6V    6:   �� *	PhoneNo+6d   50      �� 51      -   5         ��Name$
 Home��51      $
��Home��6#   $��0q�62   $
��Bold"�6F   
���  ��$
��Left=�6j   $��238,182,0,33q�6�   $��1��6�   $��98��6�   $��Italic$�6�   �� 52      -   5        $
 Exit��52      $��0q�6#   $
��Exit��67   $
��Bold"�6F   
���  ��$
��Left=�6j   $��540,180,0,0q�6�   $��1��6�   $	��Top=�6�   $��58��6�   $	��109��6�   $��Italic$�6�   54      55      56      