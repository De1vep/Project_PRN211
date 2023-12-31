﻿using Microsoft.EntityFrameworkCore;
using ProjectPhuongDat.DAO;
using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPhuongDat.GUI
{
    public partial class ShoppingGUI : Form
    {
        AlbumDAO albumDAO = new AlbumDAO();
        ArtistDAO artistDAO = new ArtistDAO();
        public List<Album> albums { get; set; }
        public int page { get; set; }
        public string cartID { get; set; }
        public User user { get; set; }
        MusicStoreContext music = new MusicStoreContext();

        public ShoppingGUI(string cartID)
        {
            InitializeComponent();
            this.cartID = cartID;
            page = 1;
            LoadShop();
        }

        public void LoadShop()
        {

            cbGenre.DataSource = music.Genres.ToList();
            cbGenre.DisplayMember = "Name";
            cbTitle.DataSource = music.Albums.ToList();
            cbTitle.DisplayMember = "Title";
            cbTitle.ValueMember = "Title";
            cbTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BindingData();
            Page(page, albums);
        }

        public void BindingData()
        {
            albums = albumDAO.LoadAllAlbum();

        }

        void Page(int page, List<Album> listA)
        {
            flplShop.Controls.Clear();
            plnShop.Controls.Add(flplShop); 
            List<Album> list = albumDAO.LoadPaginationAlbum(page, 3, listA);
            if (page == 1)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
            int rs = listA.Count % 3;
            int total;
            if (rs == 0)
            {
                total = listA.Count / 3;
            }
            else
            {
                total = listA.Count / 3 + 1;
            }
            if (page == total)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }

            foreach (var album in list)
            {   //Cau hinh cac thanh phan cua group box - picture,artist,price,addcart
                PictureBox pic = new PictureBox();
                Label price = new Label();
                Label artist = new Label();
                Button addCart = new Button();
                GroupBox grb = new GroupBox();
                int height = flplShop.Height;
                int width = flplShop.Width;
                grb.Size = new Size((width - 20) / 3, height - 10);
                pic.Image = Image.FromFile(@"E:\PRN211DAT\ProjectPhuongDat\Resources" + album.AlbumUrl + "");// thay lay duong dan Resources trong project 

                artist.TextAlign = ContentAlignment.MiddleCenter;
                price.TextAlign = ContentAlignment.MiddleCenter;
                grb.Controls.Add(pic);
                grb.Controls.Add(price);
                grb.Controls.Add(artist);
                grb.Controls.Add(addCart);
                pic.Size = new Size(grb.Width * 3 / 4, grb.Height * 3 / 5);
                pic.Location = new Point((grb.Width - pic.Width) / 2, 30);

                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                price.Location = new Point((grb.Width - price.Width) / 2, pic.Location.Y + pic.Height + 25);
                artist.Location = new Point((grb.Width - artist.Width) / 2, price.Location.Y + 30);
                addCart.Size = new Size(158, 29);
                addCart.Location = new Point((grb.Width - addCart.Width) / 2, artist.Location.Y + 30);
                addCart.Text = "Add to cart";
                addCart.Name = "btnAddCart";
                addCart.Click += AddCart_Click;
                addCart.Tag = album.AlbumId;
                grb.Text = album.Title;
                price.Text = "$" + album.Price.ToString();
                artist.Text = artistDAO.GetArtistByID(album.ArtistId).Name;
                flplShop.Controls.Add(grb);

            }
        }

        private void AddCart_Click(object? sender, EventArgs e)
        {
            MusicStoreContext music = new MusicStoreContext();

            Button add = (Button)sender;
            List<Cart> list = new List<Cart>();

            list = music.Carts.Where(p => p.CartId == cartID).ToList();
            Cart alb = list.Where(p => p.AlbumId == (int)add.Tag).FirstOrDefault();
            if (alb != null)
            {
                alb.Count += 1;
                music.Entry(alb).State = EntityState.Modified;
                music.SaveChanges();
            }
            else
            {
                music.Carts.Add(new Cart()
                {
                    CartId = cartID,
                    AlbumId = (int)add.Tag,
                    Count = 1,
                    DateCreated = DateTime.Now,

                });
                music.SaveChanges();
            }
            MessageBox.Show($"Add Product ID {(int)add.Tag} to cart");

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            page += 1;
            Page(page, albums);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            page -= 1;
            Page(page, albums);
        }

        private void cbGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            page = 1;
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                Genre genre = (Genre)cb.SelectedValue;
                albums = albumDAO.LoadAlbumByGenre(genre.GenreId);
                Page(page, albums);

            }

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadShop();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            page = 1;
            albums = albumDAO.LoadAlbumByTitle(cbTitle.Text);

            Page(page, albums);
        }



        private void BtnAdd_Click(object? sender, EventArgs e)
        {

        }


        private void lblLog_Click(object sender, EventArgs e)
        {

        }
    }

}
