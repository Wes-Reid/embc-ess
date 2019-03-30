import { Component, OnInit } from '@angular/core';
import { IncidentTask } from 'src/app/core/models';
import { Store } from '@ngrx/store';
import { AppState } from 'src/app/store';
import { takeWhile } from 'rxjs/operators';
import { Router } from '@angular/router';
import { IncidentTaskService } from 'src/app/core/services/incident-task.service';
import { UpdateIncidentTask } from 'src/app/store/incident-tasks/incident-tasks.actions';

@Component({
  selector: 'app-admin-add-task-number-confirmation',
  templateUrl: './admin-add-task-number-confirmation.component.html',
  styleUrls: ['./admin-add-task-number-confirmation.component.scss']
})
export class AdminAddTaskNumberConfirmationComponent implements OnInit {
  componentActive = true;
  currentIncidentTask$ = this.store.select(s => s.incidentTasks.currentIncidentTask);
  incidentTask: IncidentTask;

  constructor(
    private store: Store<AppState>,
    private router: Router,
    private incidentTaskService: IncidentTaskService,
  ) { }

  ngOnInit() {
    this.currentIncidentTask$.pipe(takeWhile(() => this.componentActive))
      .subscribe(i => {
        // if there are any mandatory fields that are null route back to the main component
        if (!i.taskNumber || !i.community || !i.details) {
          this.router.navigate(['task-number-edit/fill']);
        } else {
          // we have somethings to show so we show it.
          this.incidentTask = i;
        }
      });
  }
  back() {
    // go back
    this.onSave();
    this.router.navigate(['task-number-edit/fill']);
  }
  submit() {
    if (!(this.incidentTask.community && this.incidentTask.details && this.incidentTask.taskNumber)) {
      // todo go somewhere useful for this provincial user after routing is fixed.
      this.router.navigate(['']);
    } else {
      // check if this is an update
      if (this.incidentTask.id) {
        // if the volunteer has an ID we need to update
        this.incidentTaskService.updateIncidentTask(this.incidentTask)
          .subscribe(() => {
            // go back to the volunteer team dashboard
            this.router.navigate(['provincial-admin/edit-task-numbers']);
          });
      } else {
        // if the volunteer has no id we need to create a new one
        this.incidentTaskService.createIncidentTask(this.incidentTask)
          .subscribe(i => {
            // go back to the volunteer team dashboard
            this.router.navigate(['provincial-admin/edit-task-numbers']);
          });
      }
    }
  }

  onSave() {
    // save the data into ngrx state
    const incidentTask = this.incidentTask;
    this.store.dispatch(new UpdateIncidentTask({ incidentTask }))
  }

}