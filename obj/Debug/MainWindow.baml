   M S B A M L   `   `   `  ����O  KLexicialAnalysis_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LexicialAnalysis_WPFLexicialAnalysis_WPF  5   	   %    LexicialAnalysis_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LexicialAnalysis_WPF     5   	     � Title$  
MainWindow��5   	   $��401.787��6   $��528.043��6-   .��5	      � $��0,0,-0.4,-29.8q�6    � RowDefinitions 5
   
   �� 5      $
��301* �6   �� 5      $	��20* �6   .+�5   
   �� -   5        $��词法翻译��5      $
��Left=�6    $��216,332,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5   
   -   5        $��
sourceCode��5       �� AcceptsReturn . $
��Left=�69   $��92��6T   $��	37,10,0,0q�6`    �� TextWrapping$
 Wrap=�6s   $�� ��6�   $	��Top=�6�   $	��453��6�   �� 5   
   -   5        $��
outputFile��5      $
��Left=�6&   $	��153��6A   $��
37,162,0,0q�6N   $	��Top=�6b   $	��453��6z    �� View 5      �� 5      .P�5      �� $
��name��6%    �� Width$	 151��6^    �� DisplayMemberBinding 63   ��  �� Path$
 Name�6^   �� 5      $
��kind��6%   $	 151��6^    63   �� $
 Kind�6^   �� 5      $��value��6%   $	 151��6`    64   �� $ Value�6`   5      5      �� 5   
   -   5        $��打开文件��5      $
��Left=�6    $��216,120,0,0q�6;   $��75��6P   $	��Top=�6o   5      5      