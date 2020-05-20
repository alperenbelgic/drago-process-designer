import { Component, OnInit, Input, ElementRef, EventEmitter, Output } from '@angular/core';
// import { ProcessDesignerComponent } from '../process-designer/process-designer.component';
import { Field } from '../../services/field-type.service';

export class Process {
  processId: string;

  processItems: ProcessItem[] = [];
  links: Link[] = [];
}

export class Link {

  public constructor(init?: Partial<Link>) {
    Object.assign(this, init);
  }

  actionName = '';
  startItem: ProcessItem;
  endItem: ProcessItem;
}

export class ProcessItem {

  public constructor(
    public id: string,
    protected retrievedFromServer: boolean,
    public topPx: number = 80,
    public leftPx: number = 80,
    public text: string = ''
  ) {

  }

  leftPxBeforeMove = 0;
  topPxBeforeMove = 0;

  isSelected = false;
  component: ProcessItemComponent;

  links: Link[] = []; // persistent

  get width(): number {
    return this.component?.getWidth() ?? 0;
  }

  get height(): number {
    return this.component?.getHeight() ?? 0;
  }

  get middleX(): number {
    return this.leftPx + ((this.component?.getWidth() ?? 0) / 2);
  }

  get middleY(): number {
    return this.topPx + ((this.component?.getHeight() ?? 0) / 2);
  }
}

export class StepItem extends ProcessItem {

  fields: Field[] = [];

  public constructor(
    id: string,
    retrievedFromServer: boolean = false,
    stepName: string,
    topPx: number,
    leftPx: number) {
    super(id, retrievedFromServer, topPx, leftPx, stepName);
  }
}

export class ConditionItem extends ProcessItem {

  public constructor(
    id: string,
    retrievedFromServer: boolean = false,
    conditionName: string,
    topPx: number,
    leftPx: number) {
    super(id, retrievedFromServer, topPx, leftPx, conditionName);
  }
}
@Component({
  selector: 'app-process-item',
  templateUrl: './process-item.component.html',
  styleUrls: ['./process-item.component.css']
})
export class ProcessItemComponent implements OnInit {

  @Input() processItem: ProcessItem;
  @Output() linkCreated: EventEmitter<any> = new EventEmitter();
  @Output() settingDialogueOpening = new EventEmitter<ProcessItem>();
  isSettingsVisible = false;

  constructor(
    private el: ElementRef) { }

  ngOnInit(): void {
    this.processItem.component = this;
  }

  getWidth() {
    return this.el.nativeElement.offsetWidth;
  }

  getHeight() {
    return this.el.nativeElement.offsetHeight;
  }

  openSettings($event) {

    console.log('open settings');
    this.settingDialogueOpening.emit(this.processItem);
  }

  createLink($event) {
    this.linkCreated.emit({
      processItem: this.processItem,
      event: $event
    });

  }
}