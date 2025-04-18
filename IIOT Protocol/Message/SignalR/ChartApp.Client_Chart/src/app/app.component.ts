import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IChartModel } from './model/IChartModel';
import * as signalR from '@microsoft/signalr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  chart: any;
  public data: IChartModel[] | undefined;
  public bradcastedData: IChartModel[] | undefined;
  private hubConnection: signalR.HubConnection | undefined

  chartOptions = {
    title: {
      text: "Basic Column Chart in Angular"
    },
    data: [{
      type: "bar",
      dataPoints: [
        { label: "Data1", y: 10, background:'#5491DA' },
        { label: "Data2", y: 15, background:'#5491DA'  },
        { label: "Data3", y: 25, background:'#5491DA'  },
        { label: "Data4", y: 30, background:'#5491DA'  }
      ]
    }]
  };

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.startConnection();
    this.addTransferChartDataListener();
    this.addBroadcastChartDataListener();
    this.startHttpRequest();
  }

  private startHttpRequest = () => {
    this.http.get('https://localhost:5001/api/chart')
      .subscribe(res => {
        console.log(res);
      })
  }

  public startConnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:5001/chart')
      .build();
    this.hubConnection
      .start()
      .then(() => console.log('Connection started'))
      .catch(err => console.log('Error while starting connection: ' + err))
  }

  public addTransferChartDataListener = () => {
    this.hubConnection?.on('transferchartdata', (data) => {
      this.data = data;
      this.chartOptions.data[0].dataPoints.splice(0, 4);
      this.data?.forEach((obj: {
        backgroundColor: string; label: any; data: any; 
}) => {
        this.chartOptions.data[0].dataPoints.push({ label: obj.label, y: obj.data, background : obj.backgroundColor });
        this.updateChart();
      });
    });
  }

  public broadcastChartData = () => {
    const data = this.data?.map(m => {
      const temp = {
        data: m.data,
        label: m.label,
        background : m.backgroundColor
      }
      return temp;
    });
    this.hubConnection?.invoke('broadcastchartdata', data)
      .catch(err => console.error(err));
  }

  public addBroadcastChartDataListener = () => {
    this.hubConnection?.on('broadcastchartdata', (data) => {
      this.bradcastedData = data;
    })
  }

  getChartInstance(chart: object) {
    console.log('getChartInstance');
    this.chart = chart;
    this.updateChart();
  }

  public updateChart() {
    console.log('updateChart');
    this.chart.render();
  }
}
