<?php 
	$app->get('/mail/one', 'getUndanganSatu');
	$app->post('/mail/one/{key}', 'postUndanganSatu');
	$app->put('/mail/one/{key}', 'putEliminateDuplicateUndanganSatu');
	$app->get('/mail/one/{key}/{id}', 'getUndanganSatuById');
	$app->put('/mail/one/{key}/{id}', 'putUndanganSatu');
	$app->delete('/mail/one/{key}/{id}', 'deleteUndanganSatu');



	function getUndanganSatu($req, $res, $args)
	{
		$data = json_encode(array_map(function ($res)
		{
			return $res->to_array();
		}, UndanganSatuWaktu::all()));

		echo $data;

	}

	function getUndanganSatuById($req, $res, $args)
	{
		$data = json_encode(array(UndanganSatuWaktu::find($args['id'])->to_array()));

		echo $data;
	}

	function postUndanganSatu($req, $res, $args)
	{
		$attributes = json_decode($req->getBody(), true);
		UndanganSatuWaktu::create($attributes);
	};

	function putEliminateDuplicateUndanganSatu($req, $res, $args)
	{
		ActiveRecord\ConnectionManager::get_connection()->connection->query('DELETE d1 from undangan_satu_waktu d1, undangan_satu_waktu d2 WHERE d1.nomor = d2.nomor and d1.id > d2.id');
	};

	function deleteUndanganSatu($res, $req, $args)
	{
		UndanganSatuWaktu::find($args['id'])->delete();
	};