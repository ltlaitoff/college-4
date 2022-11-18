<?php

class Route
{
  public function start()
  {
    $url = $_SERVER['REQUEST_URI'];

    $newUrl = str_replace(SITE_ROOT, "", $url);
    $route = explode('/', $newUrl);

    $controller = null;
    $controller_name = null;
    $action = null;

    if (isset($route[2])) {
      $controller_name = $route[2];
    }

    if (isset($route[3])) {
      $action = $route[3];
    }

    $controller_path = 'controllers/' . strtolower($controller_name) . '.php';

    if (file_exists($controller_path)) {
      $controller = new $controller_name;
    }

    if (method_exists($controller, $action)) {
      $controller->$action();
    }
  }
}