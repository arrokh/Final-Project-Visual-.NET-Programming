<?php 
	$app->get('/mail/two', 'getUndanganDua');
	$app->post('/mail/two/{key}', 'postUndanganDua');
	$app->put('/mail/two/{key}', 'putEliminateDuplicateUndanganDua');
	$app->get('/mail/two/{key}/{id}', 'getUndanganDuaById');
	$app->put('/mail/two/{key}/{id}', 'putUndanganDua');
	$app->delete('/mail/two/{key}/{id}', 'deleteUndanganDua');



	function getUndanganDua($req, $res, $args)
	{
		$data = json_encode(array_map(function ($res)
		{
			return $res->to_array();
		}, UndanganDuaWaktu::all()));

		echo $data;

	}

	function getUndanganDuaById($req, $res, $args)
	{
		$data = json_encode(array(UndanganDuaWaktu::find($args['id'])->to_array()));

		echo $data;
	}

	function postUndanganDua($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		UndanganDuaWaktu::create($attributes);
	};

	function putUndanganDua($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		
		UndanganDuaWaktu::find($args['id'])->update_attributes($attributes);
	};

	function putEliminateDuplicateUndanganDua($req, $res, $args)
	{
		ActiveRecord\ConnectionManager::get_connection()->connection->query('DELETE d1 from undangan_dua_waktu d1, undangan_dua_waktu d2 WHERE d1.nomor = d2.nomor and d1.id > d2.id');
	};

	function deleteDuplicateData($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		
		UndanganDuaWaktu::find($args['id'])->update_attributes($attributes);
	};
	
	function deleteUndanganDua($res, $req, $args)
	{
		UndanganDuaWaktu::find($args['id'])->delete();
	};