using System.Collections.Generic;
using System;

namespace CDOrganizer.Models
{
  public class CDs
  {
    private string _title;
    private string _album;
    private string _artist;
    private static List<CDs> _instances = new List<CDs> {};

    public CDs (string title, string album, string artist)
    {
      _title = title;
      _album = album;
      _artist = artist;
    }
    public string GetTitle()
    {
      return _Title;
    }
    public void SetAlbum(string newAlbum)
    {
      _Album = newAlbum;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public static List<CDs> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
