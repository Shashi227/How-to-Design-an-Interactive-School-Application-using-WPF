   M S B A M L   `   `   `  ����U  QSchoolManagement_ExcelData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SchoolManagement_ExcelDataSchoolManagement_ExcelData  5   	   (    "SchoolManagement_ExcelData.Faculty   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4local(clr-namespace:SchoolManagement_ExcelData  5   	     � Title$  Faculty��5	   	   $	��731��6   $
��1080��6&    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X    � 	Resources 5
       �� 
TargetType   FULL Bio �� Property �� Value��%�   &	        �� 5      " ��6
   .�5      ��  � ��
 ���� 6"   �� 5       � ��
 �  ��6"   �� 5       � ��$ 	ExtraBold"�6"   �� 5       � ��$ 0q�6'   5      5      .��5      �� .+�5      � $��77��6	   $	��Top=�6   ���	#FF4572A0.+�5      �� $
��Left=�6   $��74��6/   $��	113,0,0,0q�6;   $	��Top=�6N   $	��882��6f   $��/LKSNNAME.jpeg��6r   $
��Fill=�6�   �� 5      $
��Left=�6B   $
��10 0q�6]   ��6   Z� ��6+   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6   $��25��6*   $��25��65   5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�6)   $
��10 0q�6E   .+�5      �� ��6   Z� ��6#   Z� .��5        $ Account=�6   5      �� 5      ��6   Z� ��6#   Z� .��5        $ Power=�6   5      5       5"      � 5#      $��90��6	   ���	#FF679CC9	 � ColumnDefinitions	 5$      �� 5%      $
��101* �6   �� 5&      $
��439* �6   .+�5(      �� -   5        
 ��Name$
 Home_btn��5(      $
��HOME��6   $��Center=�6-   $��0,24,0,0q�6J   $��0q�6\   $	��Top=�6p   $��56��6�   $	��113��6�   $��30(�6�   
�������$��Stencil)�6�   $
��Bold"�6�   $��Italic$�6�   
������ 6  �� 5*      $ 
Horizontal=�6   $��Center=�6)   $
��Left=�6D   $��1��6_   $��	338,0,0,0q�6o   �� 5+      $ 
Horizontal=�6   $
��Left=�6)   $��	828,0,0,0q�6D   $��Center=�6W   $��1��6r     5,      $ Phone=�6   
�������$��75��6=   $��
40,15,0,61q�6H   $��1��6\   $��Stretch=�6l    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5-      V� 5.      .~�5/      ��  �� ScaleY$ 1Q�6   �� 50      �� 51      T� 52      53      55        56      $
 Book=�6   
�������$��30��6<   $��25��6G   $��
308,11,0,0q�6S   $��1��6g     57      $ Teacher=�6   
�������$��38��6?   $��25��6J   $��	438,8,0,0q�6V   $��1��6i     58      $	 Pen=�6   
�������$��35��6;   $��24��6F   $��
556,12,0,0q�6R   $��1��6f   �� 59      -   5        $
 Save_btn��59      $��Student Record��6   $
��Left=�67   $��0q�6R   $��18(�6f   $��
678,34,0,0q�6t   
�������$	��Top=�6�   
������ $��44��6�   $	��150��6�   $��Italic$�6�   $
��Bold"�6  $��1��6  �� 5:      -   5        $��
Contact Us��5:      $��18(�6!   $��0q�6/   $
��Left=�6C   $��	2,35,0,12q�6^   
�������
������ $	��150��6�   $��Italic$�6�   $
��Bold"�6�   $��1��6�   �� 5;      -   5        $
 	About_btn��5;      $��18(�6   $��0q�6-   $��About US��6A   $
��Left=�6T   $��158,34,0,12q�6o   
�������
������ $	��134��6�   $��Italic$�6�   $
��Bold"�6�   $��1��6�     5<      $ Details=�6   
�������$��30��6?   $��24��6J   $��
203,0,0,61q�6V   $��Bottom=�6j   $��1��6�   �� 5=      -   5        $
 Faculty_btn��5=      $��Faculty��6!   $��1��63   $
��Left=�6C   $��
390,35,0,0q�6^   $	��Top=�6r   $��18(�6�   $��0q�6�   
�������
������ $��44��6�   $	��134��6�   $��Italic$�6�   $
��Bold"�6  6  �� 5>      -   5        $
 
Course_btn��5>      $��Course��6    $��1��61   $
��Left=�6A   $��268,35,0,11q�6\   $��18(�6q   $��0q�6   
�������
������ $	��134��6�   $��Italic$�6�   $
��Bold"�6�   6�   �� 5?      -   5        $
 	Apply_btn��5?      $��Apply��6   $��1��6/   $
��Left=�6?   $��
524,45,0,0q�6Z   $��18(�6n   $��0q�6|   
�������
������ $	��134��6�   $��Italic$�6�   $
��Bold"�6�   $��33��6  $	��Top=�6    5@      $ Database=�6   
�������$��46��6@   $��36��6K   $��	753,0,0,0q�6W   $��1��6j   5D      � 5E      $��86��6	   ���	#FFEDE5E5.+�5F      �� $��Department Faculty��6   $��	Condensed&�6(   $
��Left=�6A   $��41,0,0,0q�6\   $��Center=�6n   $	��608��6�   $��86��6�   $
��Bold"�6�   $��Italic$�6�   $��58(�6�   5H      � 5I      $	��355��6	   .+�5J      �� $
��Left=�6   $	��129��6&   $��	46,10,0,0q�63   $	��Top=�6F   $	��125��6^   $��/Dr Bhushan.png��6j   �� 5K      $��Bhushan A. Matad��6   $
��Left=�6&   $��
46,140,0,0q�6A   $	��Top=�6U   $��28��6m   $	��174��6y   $
��Bold"�6�   �� 5L      $
��Left=�6   $��0q�6(   $��
193,10,0,0q�6<   $����Bhushan A. Matad is working as an Associate Professor in Computer Science Department of Ramaiah Institute of Technology. His areas of interest include future work skills, and start-up software engineering.��6P    �� TextWrapping$
 Wrap=�6%  $	��Top=�69  $	��319��6Q  $	��125��6]  $��Italic$�6j  $��16(�6}  �� 5M      -   5        $

 Full��5M      #��[  6   $��	FULL  Bio��6<   $
��Left=�6P   $��193,140,0,0q�6k   $	��Top=�6�   $��35��6�   $��75��6�   �� 5N      $
��Left=�6   $	��128��6&   $��
46,188,0,0q�63   $	��Top=�6G   $	��126��6_   $��/Dr Anna.png��6k   �� 5O      $��Dr Annapurna P. Patil��6   $
��Left=�6+   $��
46,321,0,0q�6F   $	��Top=�6Z   $��28��6r   $	��174��6~   $
��Bold"�6�   �� 5P      $
��Left=�6   $��0q�6(   $��193,188,0,0q�6<   $����Dr. Annapurna P. Patil is working as Professor and Head, Department of Computer Science & Engineering, Ramaiah Institute of Technology. Her areas of interest include Wireless Networks, Artificial Intelligence, Protocol Engineering, Cloud Computing and IOT, Data Structures and Analysis of Algorithms.��6Q   $
 Wrap=�6�  $	��Top=�6�  $	��319��6�  $	��101��6�  $��Normal$�6�  $��16(�6�  �� 5Q      -	   5        $
 	Full_Copy��5Q      #��[  6   $��	FULL  Bio��6A   $
��Left=�6U   $��193,300,0,0q�6p   $	��Top=�6�   $��35��6�   $��75��6�   �� 5R      $
��Left=�6   $	��129��6&   $��
540,10,0,0q�63   $	��Top=�6G   $	��125��6_   $��/Dr Mohan kumar.png��6k   �� 5S      $��Dr. Mohana Kumar S��6   $
��Left=�6(   $��540,147,0,0q�6C   $	��Top=�6X   $��28��6p   $	��150��6|   $
��Bold"�6�   �� 5T      $
��Left=�6   $��0q�6(   $��
687,10,0,0q�6<   $����Dr. Mohana Kumar S is working as an Associate Professor in the department of Computer Science & Engineering, Ramaiah Institute of Technology. His areas of interest include subjects related to networking and software pattern. Orcid ID : https://orcid.org/0000-0003-4143-9450��6P   $
 Wrap=�6m  $	��Top=�6�  $	��383��6�  $	��122��6�  $��Italic$�6�  $��16(�6�  �� 5U      -
   5        $
 
Full_Copy1��5U      #��[  6    $��	FULL  Bio��6B   $
��Left=�6V   $��695,136,0,0q�6q   $	��Top=�6�   $��35��6�   $��75��6�   �� 5V      $
��Left=�6   $	��128��6&   $��540,188,0,0q�63   $	��Top=�6H   $	��124��6`   $��/Dr Daya.png��6l   �� 5W      $��Pramod Sunagar��6   $
��Left=�6$   $��540,318,0,0q�6?   $	��Top=�6T   $��28��6l   $	��174��6x   $
��Bold"�6�   �� 5X      $��Normal$�6   $��0q�6    $��16(�64   $
��Left=�6B   $��695,188,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��375��6�   $	��122��6�   $����Mr. Pramod Sunagar is working as an Assistant Professor in Computer Science Department of Ramaiah Institute of Technology. His areas of interest include machine learning, big data, design and analysis of algorithms, mobile application development, object oriented programming languages and data structures.

��6�   �� 5Y      -   5        $
 
Full_Copy2��5Y      #��[  6    $��	FULL  Bio��6B   $
��Left=�6V   $��695,314,0,0q�6q   $	��Top=�6�   $��36��6�   $��75��6�   5[      � 5\      $	��122��6	   
�������	 5]      �� 5^      $	��55* �6   �� 5_      $	��53* �6   .+�5a      �� $��Admission is going on...��6   
���  ��$
��Left=�6?   $��	304,0,0,0q�6Z   $��Center=�6m   $��2��6�   $	��102��6�   $	��695��6�   $
��Bold"�6�   $��58(�6�   $��Italic$�6�   5c      5d      5e      