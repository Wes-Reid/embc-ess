import { Person, Address, RelationshipType } from './';

export interface Evacuee extends Person {
  bcServicesNumber?: string;
}

export interface HeadOfHousehold extends Evacuee {
  // evacuee information (HOH and family members)
  personType: 'HOH';
  phoneNumber: string;
  noPhoneNumber: boolean | null;
  phoneNumberAlt: string;
  email: string;
  noEmail: boolean | null;
  // related entities
  primaryResidence: Address;
  mailingAddress: Address | null;
  familyMembers: FamilyMember[];
}

export interface FamilyMember extends Evacuee {
  personType: 'FMBR';
  sameLastNameAsEvacuee: boolean;
  relationshipToEvacuee: RelationshipType;
}

export interface EvacueeListItem {
  id: string;
  restrictedAccess: boolean;
  isHeadOfHousehold: boolean;
  firstName: string;
  lastName: string;
  nickname: string;
  initials: string;
  registrationId: string;
  incidentTaskNumber: string;
  evacuatedFrom: string;
  evacuatedTo: string;
  registrationCompletionDate?: Date;
  isFinalized: boolean;
  hasReferrals: boolean;
  dob?: Date;
  selfRegisteredDate?: Date;
  primaryAddress: string;
  city: string;
  province: string;
  postalCode: string;
  country: string;
}
