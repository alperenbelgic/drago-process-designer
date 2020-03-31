import { Component, OnInit, Input } from '@angular/core';
import { ProcessItem } from '../process-item/process-item.component';

@Component({
  selector: 'app-process-item-settings',
  templateUrl: './process-item-settings.component.html',
  styleUrls: ['./process-item-settings.component.css']
})
export class ProcessItemSettingsComponent implements OnInit {

  @Input() processItem: ProcessItem;

  constructor() { }

  ngOnInit(): void {
  }

}