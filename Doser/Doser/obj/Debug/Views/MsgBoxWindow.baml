   M S B A M L   `   `   `  ����@  <Doser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Doser.ViewsDoser.Views  5   	   3clr-namespace:Doser.ViewModelsDoser.ViewModels  5   	       Doser.Views.MsgBoxWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Doser.Views     5   	   4	viewmodelclr-namespace:Doser.ViewModels     5   	   $
��auto��5	   &   $	��300��64   $	��Top=�6@     � WindowStartupLocation$  CenterOwner=�6X    � 
ResizeMode$ NoResize=�6|    � SizeToContent$ Height=�6�    � Title 6	   ��  �� Path$ Title� � DataContext 5
      ,   &Doser.ViewModels.MsgBoxWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��61   $
��auto��6>   $��15q�6L   ��6   �� $ Message�6Z   �� 5   
   $��OK��6   $��1��6   $
��auto��6+   $��74,15,74,10q�69    �� 	IsDefault . 6N   5      5      