import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FavouriteService {

  private url="http://localhost:51409/api/";
  private recUrl="http://localhost:64371/api/Recommend"
  constructor(private http:HttpClient) { }

  getFavourite(userId:any){
     return this.http.get(this.url+"Favourite/"+userId);
  }

  postFavourite(body){
    return this.http.post(this.url+"Favourite/Add",body)
  }

  deleteFavourite(userId,title){
    return this.http.delete(this.url+`Favourite/${userId}/${title}`)
  }

  getRecommendation(){
    return this.http.get(this.recUrl);
  }
}
