-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 02 Mar 2018 pada 08.52
-- Versi Server: 10.1.13-MariaDB
-- PHP Version: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `koperasi`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `detail_transaksi`
--

CREATE TABLE `detail_transaksi` (
  `no` int(10) NOT NULL,
  `kode_transaksi` varchar(25) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga_total` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `detail_transaksi`
--

INSERT INTO `detail_transaksi` (`no`, `kode_transaksi`, `nama_barang`, `jumlah`, `harga_total`) VALUES
(56, '3602032018', 'Fresh Tea Madu 500 ml', 2, 12000),
(57, '3602032018', 'Bear Brand', 3, 24000),
(58, '3602032018', 'Beng-beng', 1, 1500),
(59, '3602032018', 'Obat Batuk Komix Sachet 7 ml', 1, 1500);

-- --------------------------------------------------------

--
-- Struktur dari tabel `koperasi`
--

CREATE TABLE `koperasi` (
  `no` int(10) NOT NULL,
  `nama_barang` varchar(255) NOT NULL,
  `jenis` varchar(50) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `satuan` varchar(15) NOT NULL,
  `harga_jual` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data untuk tabel `koperasi`
--

INSERT INTO `koperasi` (`no`, `nama_barang`, `jenis`, `jumlah`, `satuan`, `harga_jual`) VALUES
(1, '', 'Minuman', 80, 'pcs', '6800'),
(2, '', 'Minuman', 80, 'pcs', '6800'),
(3, '', 'Minuman', 80, 'pcs', '6800'),
(4, '', 'Minuman', 80, 'pcs', '3000'),
(5, '', 'Minuman', 80, 'pcs', '7000'),
(6, '', 'Makanan', 80, 'pcs', '8500'),
(7, 'Fresh Tea Madu 500 ml', 'Minuman', 12, 'pcs', '6000'),
(8, 'Bear Brand', 'Minuman', 16, 'pcs', '8000'),
(9, 'Q Tela Tempe 55 gr', 'Makanan', 1, 'pcs', '6300'),
(10, 'UJ Sari Kacang Ijo 250 ml', 'Minuman', 1, 'pcs', '4600'),
(11, 'Beng-beng', 'Makanan', 0, 'pcs', '1500'),
(12, 'Susu Ultra 250 ml Coklat', 'Minuman', 1, 'pcs', '5000'),
(13, 'Susu Ultra 250 ml Fullcream', 'Minuman', 1, 'pcs', '5000'),
(14, 'Susu Ultra 250 ml Strawbery', 'Minuman', 1, 'pcs', '5000'),
(15, 'Fanta 250 ml', 'Minuman', 1, 'pcs', '3500'),
(16, 'Coca Cola 250 ml', 'Minuman', 1, 'pcs', '3500'),
(17, 'Fanta Orange 390 ml', 'Minuman', 1, 'pcs', '4500'),
(18, 'Roma Malkist Coklat 120 gr', 'Makanan', 1, 'pcs', '7600'),
(19, 'Sukro Dua Kelinci 140 gr', 'Makanan', 1, 'pcs', '8500'),
(20, 'Sukro Dua Kelinci 20 gr', 'Makanan', 1, 'pcs', '1000'),
(21, 'Roma Malkist Crackers 135 gr', 'Makanan', 1, 'pcs', '6500'),
(22, '', 'Minuman', 80, 'pcs', '2500'),
(23, 'Oreo Chocolate Crème 29 gr', 'Makanan', 1, 'pcs', '1500'),
(24, 'Teh Pucuk Harum 350 ml', 'Minuman', 1, 'pcs', '3000'),
(25, 'Teh Kotak 250 ml', 'Minuman', 1, 'pcs', '3500'),
(26, 'Teh Sosro 250 ml', 'Minuman', 1, 'pcs', '3500'),
(27, 'Buah Vita Jambu 250 ml', 'Minuman', 1, 'pcs', '7600'),
(28, 'Buah Vita Lyche 250 ml', 'Minuman', 1, 'pcs', '7600'),
(29, 'Buah Vita Mango 250 ml', 'Minuman', 1, 'pcs', '7600'),
(30, 'Buah Vita Orange 250 ml', 'Minuman', 1, 'pcs', '7600'),
(31, 'Buah Vita Apple 250 ml', 'Minuman', 1, 'pcs', '7600'),
(32, 'Aqua 600 ml', 'Minuman', 1, 'pcs', '3500'),
(33, 'Aqua 300 ml', 'Minuman', 6, 'pcs', '2500'),
(34, 'S tee Botol', 'Minuman', 1, 'pcs', '3000'),
(35, 'Kopiko 780 C, 240 ml', 'Minuman', 1, 'pcs', '5800'),
(36, 'Nes Café ', 'Minuman', 1, 'pcs', '4800'),
(37, 'Pop Mie Ayam', 'Makanan', 0, 'pcs', '4500'),
(38, 'Pop Mie Bakso', 'Makanan', 0, 'pcs', '4500'),
(39, 'Kopi Susu ABC 3 in 1, 31 gr', 'Minuman', 1, 'pcs', '2500'),
(40, 'Kripik Singkong Ku Suka 60 gr', 'Makanan', 1, 'pcs', '5200'),
(41, 'Cheetos Jagung Bakar 40 gr', 'Makanan', 1, 'pcs', '3200'),
(42, 'Good Day Cappucino Sachet 25 gr', 'Minuman', 1, 'pcs', '2000'),
(43, '', 'Minuman', 80, 'pcs', '6300'),
(44, 'Indocafe Coffee Mix 3 in 1, 20 gr', 'Minuman', 0, 'pcs', '1500'),
(45, 'Rokok Dji Sam Soe', 'Rokok', 1, 'bks', '16000'),
(46, 'Rokok Marlboro', 'Rokok', 1, 'bks', '25000'),
(47, 'Rokok Gudang Garam', 'Rokok', 1, 'bks', '17000'),
(48, 'Rokok Sampoerna Mild 16', 'Rokok', 1, 'bks', '21000'),
(49, 'Fresh Care', 'Obat', 1, 'pcs', '12500'),
(50, 'Koyo Salonpas', 'Obat', 1, 'pak', '6500'),
(51, 'Obat Entrostop', 'Obat', 1, 'lbr', '7000'),
(52, 'Obat Progmag', 'Obat', 1, 'lbr', '10000'),
(53, 'Obat Antangin', 'Obat', 0, 'strip', '2500'),
(54, 'Obat Bodrex Esktra ', 'Obat', 1, 'strip', '2500'),
(55, 'Obat Bodrex Migra', 'Obat', 1, 'strip', '2500'),
(56, 'Obat Bodrex Flu dan Batuk', 'Obat', 1, 'strip', '2500'),
(57, 'Obat Diatabs', 'Obat', 1, 'strip', '3000'),
(58, 'Obat Batuk Komix Sachet 7 ml', 'Obat', 0, 'strip', '1500'),
(59, 'Max Tea Teh Tarik', 'Minuman', 1, 'pcs', '2000'),
(60, 'Hydro Coco Original 350 ml', 'Minuman', 1, 'pcs', '6500'),
(61, 'Abon Lele Besar 500 gr', 'Makanan', 1, 'bks', '65000'),
(62, 'Abon Lele Besar 250 gr', 'Makanan', 0, 'bks', '35000'),
(63, 'Ale Ale', 'Minuman', 1, 'pcs', '1000'),
(64, 'kang', 'k', 6, 'v', '2'),
(65, 'l', 'm', 0, 'i', '0'),
(66, 'okiier', 'ju', 1, 'as', '6'),
(67, 'oasdjp', 'as', 87, 'ac', '32'),
(68, 'pa', 'makanan', 100, 'iu', '7000'),
(69, 'op', 'ad', 2, 'asd', '8'),
(70, 'lkjsdx', 'as', 9, '7', '09'),
(71, 'ka', 'j', 13, 'kj', '97');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pegawai`
--

CREATE TABLE `pegawai` (
  `no` int(25) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `golongan` varchar(100) NOT NULL,
  `pusat` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pegawai`
--

INSERT INTO `pegawai` (`no`, `nama`, `golongan`, `pusat`) VALUES
(1, 'Prof. Dr. Ir. Bambang Prasetya, M.Sc', 'IV/e', ''),
(2, 'Dr. Ir. Puji Winarni, M.A', 'IV/d', ''),
(3, 'Drs. Suprapto,  MPS', 'IV/e', ''),
(4, 'Drs.. Kukuh Syaefudin Achmad, M.Sc', 'IV/d', ''),
(5, 'Dra. Dewi Odjar Ratna Komala,  MM', 'IV/e', ''),
(6, 'Mochamad Beni Nugraha, SE, MM', 'IV/d', ''),
(7, 'Ir. Budi Rahardjo,  MM', 'IV/c', ''),
(8, 'Ir.. Nasrudin Irawan, MEnvStud', 'IV/b', ''),
(9, 'Dr. Dra. Zakiyah, MM', 'IV/c', ''),
(10, 'Konny Sagala, S.Si', 'IV/c', ''),
(11, 'Drs.. Dede Erawan, M.Sc', 'IV/c', ''),
(12, 'Ir. Juliantino, MM', 'IV/d', ''),
(13, 'Ir. I Nyoman Supriyatna, M.Sc', 'IV/d', ''),
(14, 'Ir. Erniningsih', 'IV/c', ''),
(15, 'Ir. Abdul Rahman Saleh, M.Sc', 'IV/d', ''),
(16, 'Ir. Metrawinda Tunus, M.Sc', 'IV/c', ''),
(17, 'Fauzi Ahmad,  S.Kom', 'III/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(18, 'Akbar Aryanto,  ST', 'III/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(19, 'R.a Bayuarti Wahyu Kusumaningrum, SIP', 'III/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(20, 'Nursidik Fadillah,  S.Sos, MM', 'III/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(21, 'Patria Rahayu, S.Sos', 'III/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(22, 'Minanuddin, SIP,M Hum', 'IV/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(23, 'Sri Lestari Handayani,  ST', 'III/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(24, 'Muhammad Irfan, ST', 'III/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(25, 'Purwanto Hadi Saputro, S.TP', 'III/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(26, 'Kristiati Andriani,  ST, MM', 'III/d', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(27, 'Agus Setiadi', 'III/c', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(28, 'Nurlathifah, S.Si', 'III/d', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(29, 'Ponimin, SE', 'III/c', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(30, 'Retno Suciati,  SP, M.Si', 'III/d', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(31, 'Muti Sophira Hilman, S.Si, MT', 'III/d', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(32, 'Nihayati, SIP.', 'III/a', ''),
(33, 'Muhammad Bahrudin, S.Hum.', 'III/a', ''),
(34, 'Prasetyo Nugroho, S.T.', 'III/a', ''),
(35, 'Haryanto', 'II/c', 'DEPUTI BIDANG INFORMASI DAN PEMASYARAKATAN STANDARDISASI'),
(36, 'Anang Tri Setyo Utomo', 'II/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(37, 'Arif Widyantoro, S. Sos', 'III/b', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(38, 'Murdianto', 'II/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(39, 'Yopi Prasetya Haeroni, A.Md', 'II/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(40, 'Firmansyah, S.Sos', 'III/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(41, 'Ardi Cahyadi Syarif, ST', 'III/b', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(42, 'Nazirwan', 'III/b', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(43, 'Meyani', 'II/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(44, 'Dusep', 'II/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(45, 'Dedy Maulana,  A.Md', 'III/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(46, 'Anggraeni Resmi Untari, S.E', 'III/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(47, 'Farida Pari, S.I.Kom.', 'III/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(48, 'Narni Praptiani', 'II/d', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(49, 'Neneng Soidah', 'II/c', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(50, 'Restu Okkiarto Adisiswoyo, S.TP', 'III/a', 'PUSAT INFORMASI DAN DOKUMENTASI STANDARDISASI'),
(51, 'Fadly Amri, ST', 'III/b', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(52, 'Heri Kurniawan, ST', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(53, 'Eko Prihartono, SE', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(54, 'Karina Dyasti Hari, S.T.', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(55, 'Rulia Maulani Ruhiyat, S.Psi.', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(56, 'Rully Tri Juliant Putra, S.Pd', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(57, 'Dea Winiarti, S.Si', 'III/c', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(58, 'Deki Toansiba, S.I.Kom', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(59, 'Orieza Febriandhani, S.Si.', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(60, 'Tintin Prihatiningrum, SIP', 'III/c', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(61, 'Dentino Aji Sasmita, SE', 'III/b', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(62, 'Daya Aruna  Bratajaya, ST', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(63, 'Ratih Paramithasari', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(64, 'Umu Kusnawati,  A.Md', 'II/d', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(65, 'Chalid Alonto, ST', 'III/a', 'PUSAT PENDIDIKAN DAN PEMASYARAKATAN STANDARISASI'),
(66, 'Ririn Setiaasih, A.Md.', 'II/c', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(67, 'Dheni Yetiningsih, A.Md.A.K.', 'II/c', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(68, 'Dian Silviani, A.Md.', 'II/c', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(69, 'Andreas Tri Handoko', 'II/c', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(70, 'Rommy Perdana Putra, A.Md', 'II/c', 'PUSAT SISTEM PENERAPAN STANDAR'),
(71, 'Eko Agus Purnomo, A.Md', 'II/c', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(72, 'Mega Ayu Pithaloka, A.Md.', 'II/c', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(73, 'Habib Nurhasan, A.Md.', 'II/c', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(74, 'Mohammad Fahmi Aminuddin, A.Md.', 'II/c', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(75, 'Hanum Nayomi, S.T', 'III/a', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(76, 'Ayumi Hikmawati, S.E.', 'III/a', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(77, 'Desi Kurnia, S.Si', 'III/a', 'PUSAT AKREDITASI LABORATORIUM DAN LEMBAGA INSPEKSI'),
(78, 'Yeyen Febriyanti, S.T', 'III/a', 'PUSAT AKREDITASI LABORATORIUM DAN LEMBAGA INSPEKSI'),
(79, 'Arief Gunawan, S.Si.', 'III/a', 'PUSAT KERJASAMA STANDARISASI'),
(80, 'Jahiram Daniel Purba, S.Si', 'III/a', 'PUSAT KERJASAMA STANDARISASI'),
(81, 'Denok Wahyu Febrina, S.T', 'III/a', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(82, 'Andri Gandhi, S.T.P.', 'III/a', 'PUSAT SISTEM PENERAPAN STANDAR'),
(83, 'Muhamad Ari Bahtiar Al Machi, S.T.', 'III/a', 'PUSAT AKREDITASI LEMBAGA SERTIFIKASI'),
(84, 'Chandra Radityo Kusuma, A.Md', 'II/d', 'BIRO HUKUM ORGANISASI DAN HUMAS'),
(85, 'Martin Tunas Rianto, S.Sos', 'III/b', 'BIRO HUKUM ORGANISASI DAN HUMAS'),
(86, 'Mohamad Kadhafi, S.Kom', 'III/b', 'BIRO HUKUM ORGANISASI DAN HUMAS'),
(87, 'Dirga Sugama, SE', 'III/b', 'BIRO PERENCANAAN KEUANGAN DAN TATA USAHA'),
(88, 'Indra Bayu Suseno, SE', 'III/a', 'BIRO PERENCANAAN KEUANGAN DAN TATA USAHA'),
(89, 'Anjar Oktikawati, S.Si', 'III/a', 'PUSAT AKREDITASI LABORATORIUM DAN LEMBAGA INSPEKSI'),
(90, 'Bety Wahyu Hapsari, S.Gz.', 'III/a', 'DEPUTI BIDANG PENELITIAN DAN KERJASAMA STANDARDISASI'),
(91, 'Iryana Margahayu, ST, SH', 'IV/a', ''),
(92, 'Titin Resmiatin, SS, MAP', 'IV/b', ''),
(93, 'Mayastria Yekttiningtyas,  ST, M.Kom', 'IV/a', ''),
(94, 'Dra. Erni Sumarni', 'IV/b', ''),
(95, 'Elvi Syafitri,  ST', 'III/d', ''),
(96, 'Andry Ridhya Prihikmat, S. Hut, M.AP', 'IV/a', ''),
(97, 'Nur Hidayati, S.Si', 'III/d', ''),
(98, 'Ajat Sudrajat, S. Pt', 'III/d', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stockis`
--

CREATE TABLE `stockis` (
  `no` int(10) NOT NULL,
  `no_barang` int(10) NOT NULL,
  `tanggal_belanja` varchar(15) NOT NULL,
  `jumlah_barang` int(4) NOT NULL,
  `harga_beli` int(8) NOT NULL,
  `supllier` varchar(50) NOT NULL,
  `jasa_pengiriman` varchar(30) NOT NULL,
  `upah_jasa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stockis`
--

INSERT INTO `stockis` (`no`, `no_barang`, `tanggal_belanja`, `jumlah_barang`, `harga_beli`, `supllier`, `jasa_pengiriman`, `upah_jasa`) VALUES
(4, 3, 'Rabu, 31 Januar', 20, 40000, 'Roti Orchid', '', ''),
(5, 1, 'Rabu, 31 Januar', 40, 600000, 'Alfamart', '', ''),
(6, 2, 'Rabu, 31 Januar', 20, 500000, 'Alfamart', '', ''),
(8, 3, 'Rabu, 31 Januar', 5, 50000, 'alfamart', '', ''),
(10, 33, 'Rabu, 31 Januar', 5, 5000, 'alfamart', '', ''),
(11, 1, 'Kamis, 01 Febru', 30, 6800, 'Transmart', '', ''),
(12, 4, 'Rabu, 14 Februa', 100, 6800, 'jakmania', '', ''),
(13, 7, 'Selasa, 20 Febr', 4, 6000, 'a', 'asdd', '122112'),
(14, 7, 'Selasa, 20 Febr', 100, 5000, 'a', 'as', '2213');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stok_barang`
--

CREATE TABLE `stok_barang` (
  `no` int(10) NOT NULL,
  `jumlah_stok` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stok_barang`
--

INSERT INTO `stok_barang` (`no`, `jumlah_stok`) VALUES
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(26, 0),
(43, 50),
(62, 7),
(62, 9),
(62, 1),
(62, 11),
(36, 9),
(44, 9),
(62, 8),
(62, 11),
(62, 11),
(62, 11),
(62, 11),
(62, 7),
(1, 8),
(3, 21),
(1, 41),
(2, 21),
(3, 26),
(33, 6),
(1, 50),
(4, 101),
(7, 5),
(7, 105);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_login`
--

CREATE TABLE `tbl_login` (
  `username` varchar(8) NOT NULL,
  `password` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_login`
--

INSERT INTO `tbl_login` (`username`, `password`) VALUES
('aaa', 'ssss'),
('admin', '031101'),
('asfqwfg', 'dskjvds'),
('azmi', 'azmi'),
('bintang', 'safaf'),
('bintangg', 'ganteng'),
('egfew', 'advks'),
('jaj', 'dklhmer'),
('sari', 'gumbira'),
('sarii', 'Gumbira'),
('sariii', 'gumbirae'),
('sariiiii', 'gumbirae');

-- --------------------------------------------------------

--
-- Struktur dari tabel `totalperbulan`
--

CREATE TABLE `totalperbulan` (
  `no` int(10) NOT NULL,
  `tanggal_bulan _tahun` varchar(30) NOT NULL,
  `total` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `no` int(10) NOT NULL,
  `kode_transaksi` varchar(25) NOT NULL,
  `tanggal_transaksi` varchar(50) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_total` int(10) NOT NULL,
  `cash` int(10) NOT NULL,
  `kembalian` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`no`, `kode_transaksi`, `tanggal_transaksi`, `nama`, `nama_barang`, `harga_total`, `cash`, `kembalian`) VALUES
(51, '3602032018', 'Jumat, 02 Maret 2018', 'Anang Tri Setyo Utomo', 'Fresh Tea Madu 500 ml', 12000, 0, 0),
(52, '3602032018', 'Jumat, 02 Maret 2018', 'Anang Tri Setyo Utomo', 'Bear Brand', 24000, 0, 0),
(53, '3602032018', 'Jumat, 02 Maret 2018', 'Anang Tri Setyo Utomo', 'Beng-beng', 1500, 0, 0),
(54, '3602032018', 'Jumat, 02 Maret 2018', 'Anang Tri Setyo Utomo', 'Obat Batuk Komix Sachet 7 ml', 1500, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  ADD PRIMARY KEY (`no`),
  ADD KEY `kode_transaksi` (`kode_transaksi`),
  ADD KEY `nama_barang` (`nama_barang`);

--
-- Indexes for table `koperasi`
--
ALTER TABLE `koperasi`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `stockis`
--
ALTER TABLE `stockis`
  ADD PRIMARY KEY (`no`),
  ADD KEY `no_barang` (`no_barang`);

--
-- Indexes for table `tbl_login`
--
ALTER TABLE `tbl_login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `totalperbulan`
--
ALTER TABLE `totalperbulan`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`no`),
  ADD KEY `kode_transaksi` (`kode_transaksi`),
  ADD KEY `nama_barang` (`nama_barang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detail_transaksi`
--
ALTER TABLE `detail_transaksi`
  MODIFY `no` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;
--
-- AUTO_INCREMENT for table `koperasi`
--
ALTER TABLE `koperasi`
  MODIFY `no` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;
--
-- AUTO_INCREMENT for table `pegawai`
--
ALTER TABLE `pegawai`
  MODIFY `no` int(25) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;
--
-- AUTO_INCREMENT for table `stockis`
--
ALTER TABLE `stockis`
  MODIFY `no` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `totalperbulan`
--
ALTER TABLE `totalperbulan`
  MODIFY `no` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `no` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;
--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `stockis`
--
ALTER TABLE `stockis`
  ADD CONSTRAINT `stockis_ibfk_1` FOREIGN KEY (`no_barang`) REFERENCES `koperasi` (`no`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
