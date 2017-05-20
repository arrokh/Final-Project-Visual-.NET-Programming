<?php 
	$app->get('/user', 'getUsers');
	$app->post('/user/{key}', 'postUser');
	$app->get('/user/{key}/{id}', 'getUserById');
	$app->put('/user/{key}/{id}', 'putUser');
	$app->delete('/user/{key}/{id}', 'deleteUser');

	function getUsers($req, $res, $args)
	{
		$data = json_encode(array_map(function ($res)
		{
			return $res->to_array();
		}, User::all()));

		echo $data;

	}

	function getUserById($req, $res, $args)
	{
		$data = json_encode(array(User::find($args['id'])->to_array()));

		echo $data;
	}

	function postUser($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		User::create($attributes);
	};

	function putUser($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		
		User::find($args['id'])->update_attributes($attributes);
	};

	function deleteUser($res, $req, $args)
	{
		User::find($args['id'])->delete();
	};