-- phpMyAdmin SQL Dump
-- version 4.5.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 04, 2016 at 02:16 AM
-- Server version: 5.7.9
-- PHP Version: 5.6.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `persuratan`
--

-- --------------------------------------------------------

--
-- Table structure for table `api`
--

DROP TABLE IF EXISTS `api`;
CREATE TABLE IF NOT EXISTS `api` (
  `id_user` int(10) NOT NULL,
  `token` varchar(256) NOT NULL,
  PRIMARY KEY (`token`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `api`
--

INSERT INTO `api` (`id_user`, `token`) VALUES
(1, 'cxmvbajcb2u3idb2ua4irh48r7hq48rhdjkfanjkcsnd'),
(2, 'gjoa4ijga4089gj8jgaodigj02jg02j842fj2084jf4f');

-- --------------------------------------------------------

--
-- Table structure for table `undangan_dua_waktu`
--

DROP TABLE IF EXISTS `undangan_dua_waktu`;
CREATE TABLE IF NOT EXISTS `undangan_dua_waktu` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `nomor` varchar(256) NOT NULL,
  `lampiran` varchar(256) NOT NULL,
  `hal` varchar(256) NOT NULL,
  `tanggal_surat` varchar(256) NOT NULL,
  `diperuntukan` varchar(256) NOT NULL,
  `nama_kegiatan` varchar(256) NOT NULL,
  `tema_kegiatan` varchar(256) NOT NULL,
  `hari_kegiatan1` varchar(256) NOT NULL,
  `tanggal_kegiatan1` varchar(256) NOT NULL,
  `waktu_kegiatan1` varchar(256) NOT NULL,
  `tempat_kegiatan1` varchar(256) NOT NULL,
  `hari_kegiatan2` varchar(256) NOT NULL,
  `tanggal_kegiatan2` varchar(256) NOT NULL,
  `waktu_kegiatan2` varchar(256) NOT NULL,
  `tempat_kegiatan2` varchar(256) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=76 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `undangan_dua_waktu`
--

INSERT INTO `undangan_dua_waktu` (`id`, `nomor`, `lampiran`, `hal`, `tanggal_surat`, `diperuntukan`, `nama_kegiatan`, `tema_kegiatan`, `hari_kegiatan1`, `tanggal_kegiatan1`, `waktu_kegiatan1`, `tempat_kegiatan1`, `hari_kegiatan2`, `tanggal_kegiatan2`, `waktu_kegiatan2`, `tempat_kegiatan2`) VALUES
(75, '12.4.1/UKM24.5.4.1/KN/2016', '2 Lampiran', 'Undangan', '28 April 2016', 'Saya', 'Suka Bisa', 'Tidak Takut Bnar', 'Rabu', '11 April 2016', '18.00', 'Makan', 'Kamis', '12 April 2016', '19.00', 'Nasi');

-- --------------------------------------------------------

--
-- Table structure for table `undangan_satu_waktu`
--

DROP TABLE IF EXISTS `undangan_satu_waktu`;
CREATE TABLE IF NOT EXISTS `undangan_satu_waktu` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `nomor` varchar(256) NOT NULL,
  `lampiran` varchar(256) NOT NULL,
  `hal` varchar(256) NOT NULL,
  `tanggal_surat` varchar(256) NOT NULL,
  `diperuntukan` varchar(256) NOT NULL,
  `nama_kegiatan` varchar(256) NOT NULL,
  `tema_kegiatan` varchar(256) NOT NULL,
  `hari_kegiatan` varchar(256) NOT NULL,
  `tanggal_kegiatan` varchar(256) NOT NULL,
  `waktu_kegiatan` varchar(256) NOT NULL,
  `tempat_kegiatan` varchar(256) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=341 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `undangan_satu_waktu`
--

INSERT INTO `undangan_satu_waktu` (`id`, `nomor`, `lampiran`, `hal`, `tanggal_surat`, `diperuntukan`, `nama_kegiatan`, `tema_kegiatan`, `hari_kegiatan`, `tanggal_kegiatan`, `waktu_kegiatan`, `tempat_kegiatan`) VALUES
(1, '2.11.3/UN32.5.6.6/KM/2015', '2 Lembar', 'Undangan', '27 April 2016', 'Yth. Dekan', 'Line a Design and Contest', 'Go Green Go Robot Start Battle', 'Sabtu s. d. Minggu', '14 Oktober 2016', '08.00-17.00 WIB', 'Gedung Sasana Budaya UM'),
(3, '12.5.1/UN32.5.6.6/KM/2015', '4 lembar', 'Undangan', '27 April 2016', 'Yth. Ketua Jurusan Teknik Elektro\r\nFakultas Teknik Universitas Negeri Malang', 'Line Tracer Design and Contest', 'Go Green Go Robot Start Battle', 'Sabtu s. d. Minggu', '21 - 22 Juni 2016', '08.00 - 10.00', 'Gedung Sasana Krida UM'),
(204, '29.4.12/UN11.5.6.1/KM/2016', '1 Lembar', 'Undangan', '28 April 2016', 'Jl. Lurus', 'Juara Bergilir', 'Bersatu Kita Teguh', 'Senin', '1 Mei 2016', '08.00', 'Disana'),
(340, '28.4.1/KM.5.6.4/KN/2016', '1 Lampiran', 'Undangan', '28 April 2016', 'Yth. Ketua Jurusan Teknik Elektro', 'Persentasi Tugas Besar VB', 'SIPP', 'Sabtu - Minggu', '1 Mei 2016', '08.00 - 09.00', 'Lab H5'),
(119, '27.4.1/UN32.5.6.6/KM/2016', '2 Lembar', 'Undangan', '27 April 2016', 'Yth. Teman sekelomok\r\nS1 2014', 'Kerja Kelomok', '1 Tugas Besar Untuk Semua', 'Kamis', '27 Mei', '08.00 samai selesai', 'Universitas Negeri Malang'),
(104, '12.4.1/UN22.5.6/KM/2016', '1 Lembar', 'Undangan', '28 April 2016', 'Jl. Jalan', 'Karawitan', 'Menabuh', 'Kamis', '21 April 2016', 'Mulai - Selesai', 'Aula');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `email` varchar(256) NOT NULL,
  `full_name` varchar(256) NOT NULL,
  `position` varchar(256) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `email`, `full_name`, `position`) VALUES
(1, 'alvin', 'mokrajbal', 'alv1n@live.com', 'Noor Octavian Anwar', 'admin'),
(2, 'abid', 'labjarkom', 'abid@ragil.com', 'Abid Ragil Pambagio', 'admin'),
(3, 'radha', 'bismillah', 'radha@nia.com', 'Radhania Afika', 'admin');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
