import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { SearchResult } from 'src/app/models/search-result';
import { SearchService } from 'src/app/Services/search.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor(private builder:FormBuilder,private router:Router, public service:SearchService) { }

  searchList=this.builder.group({
    category:['']
  });

  items: Array<any>;
  gridColumns=4;
  searchResult:SearchResult;
  ngOnInit(): void {
  }
onSubmit(){
  this.service.getSearchList(this.searchList.value).subscribe(
  data=>{
    this.items=data['items'];
    console.log(this.items);
  },
  err=>{
    alert("Enter category to search");
 });
 this.searchList.reset();
  }
}
