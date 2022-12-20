<?
	class Route{
		function start(){
			$url = $_SERVER['REQUEST_URI'];
			$route = explode('/', $url);
			if($route[2]){
				$controller_name = $route[2];
			}else{
				$controller_name = CONTROLLERDEFAULT;
			}
					
			if($route[3]){
				$action = $route[3];
			}else{
				$action = ACTIONDEFAULT;
			}	

			$controller_path = 'controllers/'.strtolower($controller_name).'.php';
			$model_path = 'models/'.strtolower($controller_name).'.php';
			
			if(file_exists($model_path)){
				include $model_path;
			}			

			if(file_exists($controller_path)){
				include $controller_path;
				$controller_name .='Controller';
				$controller = new $controller_name;
			}		
			
			if(method_exists($controller, $action)){
				$controller->$action();
			}
		}
	}
?>