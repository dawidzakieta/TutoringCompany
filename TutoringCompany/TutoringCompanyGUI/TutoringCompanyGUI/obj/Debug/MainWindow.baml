   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5   	   #    TutoringCompanyGUI.MainWindow   5      (src clr-namespace:TutoringCompanyGUI  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Tutoring��5   	   $	��350��6   $	��500��6'    � 
ResizeMode$ CanMinimize=�63    � WindowStyle$
 None=�5	   	    � AllowsTransparency .  � 	Resources 5
       �� 
TargetType �� Property   
Background �� Value  MainButtons �� BasedOn	 �� MergedDictionaries
 �� Source�� 5   
   	 5      �� 5      $
 Styles.xaml?�6%   �� 5      $
 TitleGrid.xaml?�6%   %�   '�       7   '�� D     7  �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6(   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��30* �6   .+�5   
   �� -   5         ��Name$ TitleContent��5        	TitleGrid#��[ 6/   � 5   
   $��1��6   .+�5      �� -   5         ��Name$ tutors��5      $��Tutors��6)   $��0,90,0,0q�6=   6P   �� 5       -   5        $ clients��5       $��Clients��6)   $��0,20,0,0q�6=   6P   �� 5!      -   5        $ students��5!      $��Students��6)   $��	0,160,0,0q�6=   6P   �� 5"      -   5        $ lessons��5"      $��Lessons��6)   $��	0,230,0,0q�6=   6P   5#      5$      5%      