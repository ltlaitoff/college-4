<?php
include('controllers/files.php');
define('SITE_ROOT', 'PR6/');

include('route.php');

$route = new Route();
$route->start();

include('views/index.php');