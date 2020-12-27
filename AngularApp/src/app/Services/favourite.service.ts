import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FavouriteService {

  private url="http://localhost:51409/api/";
  constructor(private http:HttpClient) { }

  getFavourite(){
     return this.http.get(this.url+"Favourite");
  }

  postFavourite(body){
    return this.http.post(this.url+"Favourite/Add",body)
  }

  deleteFavourite(id,title){
    return this.http.delete(this.url+`Favourite/${id}/${title}`)
  }
  
}
