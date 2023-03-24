# Treasure Hunt Solver

## Daftar Isi

- [Deskripsi Program](#deskripsi-program)
- [Anggota Kelompok](#anggota-kelompok)
- [Daftar Pembagian Tugas](#daftar-pembagian-tugas)
- [Cara Menjalankan Program](#cara-menjalankan-program)
- [Cara Menggunakan Program](#cara-menggunakan-program)
- [Screenshots](#screenshots)

## Deskripsi Program

Sebuah aplikasi dengan GUI sederhana
yang dapat mengimplementasikan BFS (Breadth-First Search) dan DFS (Depth-First Search) untuk mendapatkan rute memperoleh seluruh treasure atau harta karun yang ada. Program dapat menerima dan membaca input sebuah file txt yang berisi maze yang akan ditemukan solusi rute mendapatkan treasure-nya.

Input maze berbentuk segi-empat dengan spesifikasi simbol sebagai berikut :

- K : Krusty Krab (Titik awal)
- T : Treasure
- R : Grid yang mungkin diakses / sebuah lintasan
- X : Grid halangan yang tidak dapat diakses

## Fitur Pencarian

Terdapat 3 fitur utama algoritma pencarian, yaitu:

1. DFS
2. DFS Multivisit
3. BFS

Terdapat juga tambahan untuk penyelesaian permasalahan TSP (Traveling Salesman Problem) pada algoritma BFS

Program juga memiliki fitur sleep time yang mengatur durasi atau jeda visualisasi setiap langkah selama proses pencarian solusi

## Anggota Kelompok

| NIM      | Nama                           |
| -------- | ------------------------------ |
| 13521063 | Salomo Reinhart Gregory Manalu |
| 13521071 | Margaretha Olivia Haryono      |
| 13521160 | Dimas Sakti Widyatmaja         |

## Daftar Pembagian Tugas

| Bagian Program | Yang Mengerjakan |
| -------------- | ---------------- |
| GUI            | Salomo           |
| DFS            | Olivia           |
| BFS            | Sakti            |

## Cara Menjalankan Program

### 1. Clone repo

```sh
git clone git@github.com:margarethaolivia/Tubes2_karepmu.git
```

atau bila menggunakan https

```sh
git clone https://github.com/margarethaolivia/Tubes2_karepmu.git
```

### 2. Run the app

Pada Windows, jalankan

```sh
./bin/TreasureHuntSolver.exe
```

atau pada Linux, jalankan

```sh
./bin/TreasureHuntSolver
```

## Cara Menggunakan Program

1. Masukkan file peta maze treasure hunt dengan menekan tombol “Enter File”
2. Pilih salah satu option button untuk jenis algoritma yang ingin digunakan. Pilihan algoritma yang ada yaitu DFS, DFS (multivisit), dan BFS. Terdapat juga tambahan checklist untuk TSP jika ingin solusi yang dihasilkan kembali ke titik awal.
3. Masukkan durasi jeda setiap langkah yang diinginkan. Secara default, program tidak memberi jeda langkah.
4. Tekan tombol “Visualize” untuk menampilkan peta maze yang telah dipilih. Jika masukan file maze tidak valid, maka program akan menampilkan pesan error pada layar. Jika masukan telah sesuai, maka akan terlihat visualisasi dari peta dengan keterangan warna sebagai berikut.
   - K (titik awal) : merah
   - T (treasure) : ungu
   - R (lintasan) : putih
   - X (halangan) : hitam
5. Tekan tombol “Search” untuk memulai proses pencarian pada maze sesuai algoritma yang dipilih dengan jeda waktu tiap langkah sesuai masukan sebelumnya. Pada visualisasi langkah, terdapat beberapa warna yang digunakan dengan keterangan warna di bawah ini. Pada kasus multivisit, semakin sering suatu grid dikunjungi, maka warna dari grid tersebut akan semakin gelap.
   - lintasan (R) yang telah dikunjungi : hijau
   - treasure (T) yang telah dikunjungi : biru
   - titik awal (K) telah dikunjungi : ungu muda
6. Setelah proses pencarian selesai, program menampilkan rute pencariannya beserta waktu eksekusi, jumlah langkah, dan jumlah nodes yang dikunjungi selama proses pencarian.

# Screenshots

![screenshots](doc/screenshot.JPG)
