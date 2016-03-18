<?php
include_once('../class/page_base.class.php');

$test = new page_base('TEST');

$test->corps="<center>Lorem ipsum dolor sit amet, consectetur adipiscing elit.
Curabitur id nibh et odio suscipit congue sit amet eget dolor.
Integer sit amet diam facilisis, tincidunt dolor et, convallis ipsum.
Maecenas iaculis mi eu tortor ultricies, nec interdum ipsum porttitor.
In id nunc malesuada, sodales risus non, elementum urna.
Vestibulum non justo in libero vestibulum rutrum et ut augue.
Pellentesque non nulla mattis, fringilla mi eu, dapibus sem.
Ut et nibh viverra, vestibulum tellus egestas, tincidunt ipsum.
Fusce non odio et turpis molestie tempus.
Vivamus sed ex eu ex consequat dapibus convallis in nibh.
Aliquam ac sem vehicula nulla feugiat porttitor.
Phasellus vitae nulla in quam mollis egestas.
Nulla ultrices dui id dignissim eleifend.
Proin ut sapien sed lorem consectetur pellentesque.
Phasellus ac libero finibus lacus tempus bibendum.
Aliquam viverra orci eu massa sagittis, vitae posuere sapien ultrices.</center>";

$test->afficher();
?>