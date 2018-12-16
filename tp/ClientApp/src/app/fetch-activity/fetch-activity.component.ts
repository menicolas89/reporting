import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatInputModule } from '@angular/material/input';

@Component({
  selector: 'app-activity-data',
  templateUrl: './fetch-activity.component.html'
})
export class FetchActivityComponent {
  public acts: Activity[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Activity[]>(baseUrl + 'api/Activity').subscribe(result => {
      this.acts = result;
    }, error => console.error(error));
  }
}

interface Activity {
  id: number;
  name: string;
  active: boolean;
}
