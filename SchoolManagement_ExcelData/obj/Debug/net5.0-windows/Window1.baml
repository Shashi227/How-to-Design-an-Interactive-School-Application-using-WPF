   M S B A M L   `   `   `  ����U  QSchoolManagement_ExcelData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SchoolManagement_ExcelDataSchoolManagement_ExcelData  5   	   (    "SchoolManagement_ExcelData.Window1   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:SchoolManagement_ExcelData     5   	     � Title$  Window1��5   	   $	��483��6   $
��1095��6&    � 	Resources 5
       �� 
TargetType   MyStyle1 �� Property �� Value  MyStyle2  MyStyle3  MyStyle4  MyStyle5  MyStyle6��%�  &	        &	 �     &	 6    &	 �    &	 l    &	     �� 5   
   " ��6   .�5      ��  � ��
 �  ��6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 	ExtraBold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��
 � � �6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 	ExtraBold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��
 � ���6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 	ExtraBold"�6+   5      �� 5   
   " ��6   .�5      ��  � ��
 ��� �6+   �� 5       � ��
 �   �6+   �� 5        � ��$ 	ExtraBold"�6+   5!      �� 5#   
   " ��6   .�5$      ��  � ��
 ����6+   �� 5%       � ��
 �   �6+   �� 5&       � ��$ 	ExtraBold"�6+   5'      �� 5)   
   " ��6   .�5*      ��  � ��
 ���@�6+   �� 5+       � ��
 �   �6+   �� 5,       � ��$ 	ExtraBold"�6+   5-      51      .��53      � 
�������$
��Left=�6"   $
��1086��6=   .+�54   
   �� $��
Student ID��6   $
��Left=�6%   $��
142,60,0,0q�6@   $	��Top=�6T   $	��113��6l   $��37��6x   �� 55   
   $
��Name��6   $
��Left=�6   $��
142,97,0,0q�6:   $	��Top=�6N   $��91��6f   �� 56   
   $��Email��6   $
��Left=�6    $��142,148,0,0q�6;   $	��Top=�6P   $��91��6h   �� 57   
   $��Phone No��6   $
��Left=�6#   $��142,192,0,0q�6>   $	��Top=�6S   $��28��6k   $	��110��6w   �� 58   
   $	��DOB��6   $
��Left=�6   $��142,237,0,0q�69   $	��Top=�6N   $	��105��6f   �� 59   
   -   5         ��Name$ std_id��59      $
��Left=�6"   $��23��6=   $��
255,60,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��107��6�   �� 5:   
   -   5        $ std_name��5:      $
��Left=�6$   $��23��6?   $��255,108,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��107��6�   �� 5;   
   -   5        $ std_phoneno��5;      $
��Left=�6'   $��23��6B   $��255,197,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��107��6�   (  "System.Windows.Controls.DatePicker  5<   
   -   5          Name$ std_dob��5<      $
��Left=�6&   $��255,240,0,0q�6A   $	��Top=�6V   �� 5=   
   -   5        $ 	std_email��5=      $
��Left=�6%   $��23��6@   $��255,148,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��107��6�    J� RenderTransformOrigin$ -0.317,-0.272&�6�   �� 5>   
   -   5        	 ��Name$	 add_btn��5>      $	��Add��6"   #��[  60   $
��Left=�6R   $��142,304,0,0q�6m   $	��Top=�6�   $��75��6�   6�   �� 5?   
   -   5        $	 
delete_btn��5?      $��Delete��6%   #��[ 66   $
��Left=�6Y   $��255,304,0,0q�6t   $	��Top=�6�   $��75��6�   $ 0.037,0.512&�6�   6�   �� 5@   
   -   5        $	 
update_btn��5@      $��Update��6%   #��[ 66   $
��Left=�6X   $��362,304,0,0q�6s   $	��Top=�6�   $��75��6�   6�   �� 5A   
   -	   5        $	 	reset_btn��5A      $��Reset��6$   #��[ 64   $
��Left=�6V   $��255,359,0,0q�6q   $	��Top=�6�   $��75��6�   $ 0.487,1.575&�6�   6�   �� 5B   
   -
   5        $	 save_btn��5B      $
��Save��6#   #��[ 62   $
��Left=�6T   $��142,359,0,0q�6o   $	��Top=�6�   $��75��6�   6�   �� 5C   
   $��Student Information��6   $
��Left=�61   $	��268��6L   $��	84,10,0,0q�6Y   $	��Top=�6l   $	��384��6�   �� 5D   
   -   5        $	 create_excel_btn��5D      $��	Open Xaml��6+   #��[ 6?   $
��Left=�6a   $��
344,10,0,0q�6|   $	��Top=�6�   $��93��6�   $ 	0.4,1.962&�6�   6�   ]� 5E   
   $
��Left=�6   $��73��6/   $��False��6;   $��
473,10,0,0q�6Q   $	��Top=�6e   $	��603��6}   &   System.Windows.Controls.DataGrid  5H   
   -   5        $��dataGridStudent��5H      
   AutoGenerateColumns$
 False��6*      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6F      RowBackground
 �����$��2��5J   H   
����ح�$��473,88,10,27q�6l    5L      =  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�   '        �� 5M      "  6   .�5N      ��  � ��
 ���@�63   �� 5O       � ��$ SemiBold"�63   �� 5P       � ��
 �   �64   �� 5Q       � ��$ 0,0,1,2q�68   5R      5S         Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      -   5        
Student_ID��,  &System.Windows.Controls.DataGridColumn   Header$ 
Student_ID��5U   9      MinWidth$ 90Q�6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6[   �� *
Student_ID+  5V      -   5        Name��$
 Name��5V   3   $	 120Q�6A    6P   �� *Name+  5W      -   5        	Email��$ Email��5W   4   $	 150Q�6C    6R   �� *Email+  5X      -   5        PhoneNO��$ PhoneNo��5X   6   $	 120Q�6G    6V   �� *	PhoneNO+  5Y      -   5        DOB��$	 DOB��5Y   2   $ 80Q�6?    6M   �� *DOB+5[      �� 5b   
   -   5        $��Student Data��5b      #��[ 6(   $
��Left=�6J   $��
899,10,0,0q�6e   $	��Top=�6y   $	��121��6�   $��68��6�   5d      �� 5e   
   -   5        $	 second_window��5e      $��GoTO Second Window��6(   #��[ 6F   $
��Left=�6h   $��292,394,0,0q�6�   $	��Top=�6�   $	��145��6�   $��46��6�   6�   �� 5f   
   -   5        $	 First_Window��5f      $��GoTO First Window��6'   #��[ 6C   $
��Left=�6e   $��142,394,0,0q�6�   $	��Top=�6�   $	��134��6�   $��46��6�   6�   5j      5k      