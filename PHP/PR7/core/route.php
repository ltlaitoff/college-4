<?php
class Route
{
    function start()
    {
        $url = $_SERVER['REQUEST_URI'];

        $newUrl = str_replace(SITE_ROOT, "", $url);
        $route = explode('/', $newUrl);

        $action = ACTIONDEFAULT;
        $controller_name = CONTROLLERDEFAULT;

        if (isset($route[2])) {
            $controller_name = $route[2];
        }

        if (isset($route[3])) {
            $action = $route[3];
        }

        $controller_path = 'controllers/' . strtolower($controller_name) . '.php';
        $model_path = 'models/' . strtolower($controller_name) . '.php';

        if (file_exists($model_path)) {
            include $model_path;
        }

        if (file_exists($controller_path)) {
            include $controller_path;
            $controller_name .= 'Controller';
            $controller = new $controller_name;
        }

        if (method_exists($controller, $action)) {
            $controller->$action();
        }
    }
}