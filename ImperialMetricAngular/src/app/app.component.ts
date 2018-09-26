import { Component } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Imperial-Metric';
  value:string = '0';
  Inch:number;
  Yard:number;
  Mile:number;
  Foot:number;
  Metre:number;
  Metree:number;
  Metreee:number;
  Metreeee:number;

  inch:boolean;
  yard:boolean;
  mile:boolean;
  foot:boolean;
  metre:boolean;
  metree:boolean;
  metreee:boolean;
  metreeee:boolean;

  constructor(private httpClient:HttpClient){}
  onNameKeyUp(event:any){
    console.log(event.target.value);
    this.value = event.target.value;
    this.inch=false;
    this.yard = false;
    this.metre = false;
    this.foot = false;
    this.yard = false;
    this.metree = false;
    this.metreee = false;
    this.metreeee =false;
  }
  MetreToInch(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/MetreToInch/' + this.value)
    .subscribe(
      
      (data:any) => {
        
        this.Inch = data.MetreToInchResult;
        this.inch = true;
        console.log(data.MetreToInchResult);
        
      }

    )
    this.value = '0';
  }
  MetreToFoot(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/MetreToFoot/' + this.value)
    .subscribe(

      (data:any) => {
        
        this.Foot = data.MetreToFootResult;
        this.foot = true;
        console.log(data.MetreToFootResult);
        
      }

    )
    this.value = '0';
  }
  MetreToYard(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/MetreToYard/' + this.value)
    .subscribe(

      (data:any) => {
        this.Yard = data.MetreToYardResult;
        this.yard = true;
        console.log(data.MetreToYardResult);
      }

    )
    this.value = '0';
  }
  MetreToMile(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/MetreToMiles/' + this.value)
    .subscribe(

      (data:any) => {
        this.Mile = data.MetreToMilesResult;
        this.mile = true;
        console.log(data.MetreToMilesResult);
      }

    )
    this.value = '0';
  }
  InchToMetre(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/InchToMetre/' + this.value)
    .subscribe(

      (data:any) => {
        this.Metre = data.InchToMetreResult;
        this.metre = true;
        console.log(data.InchToMetreResult);
      }

    )
    this.value = '0';
  }
  FootToMetre(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/FootToMetre/' + this.value)
    .subscribe(

      (data:any) => {
        this.Metree = data.FootToMetreResult;
        this.metree = true;
        console.log(data.FootToMetreResult);
      }

    )
    this.value = '0';
  }
  YardToMetre(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/YardToMetre/' + this.value)
    .subscribe(

      (data:any) => {
        this.Metreee = data.YardToMetreResult;
        this.metreee = true;
        console.log(data.YardToMetreResult);
      }

    )
    this.value = '0';
  }
  MileToMetre(){
    this.httpClient.get('http://localhost:62293/ImperialMetric.svc/MilesToMetre/' + this.value)
    .subscribe(

      (data:any) => {
        this.Metreeee = data.MilesToMetreResult;
        this.metreeee = true;
        console.log(data.MilesToMetreResult);
      }

    )
    this.value = '0';
  }

}
