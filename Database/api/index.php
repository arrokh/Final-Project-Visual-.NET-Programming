<?php 
	require 'vendor/autoload.php';

	$app = new \Slim\App();

	ActiveRecord\Config::initialize(function($cfg)
	{
	    $cfg->set_model_directory('models');
	    $cfg->set_connections(array(
	        'development' => 'mysql://root@localhost/persuratan'
	        ));
	});

	function authKey($token)
	{
		return Api::find($token);
	}

	require 'routing/user_api.php';
	require 'routing/undangan_satu_waktu_api.php';
	require 'routing/undangan_dua_waktu_api.php';

	$app->run();

 ?>