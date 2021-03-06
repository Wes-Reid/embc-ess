// tslint:disable
import { of } from 'rxjs';

const routes = {
  // default (not-found) route
  'api/not-found': {
    error: {
      status: 404,
      error: 'NOT_FOUND',
      message: 'Route not found!',
    },
  },

  // lookup tables
  'api/countries': useEnvelope([
    { id: '1', name: 'Canada', active: true },
    { id: '2', name: 'United States', active: true },
    { id: '3', name: 'Australia', active: true },
    { id: '4', name: 'Bahamas, The', active: true },
    { id: '5', name: 'Cote d\'Ivoire', active: true },
    { id: '6', name: 'Japan', active: true },
  ]),

  'api/regions': useEnvelope([
    { id: '1', name: 'Vancouver Island', active: true },
    { id: '2', name: 'South West', active: true },
    { id: '3', name: 'Central', active: true },
    { id: '4', name: 'South East', active: true },
    { id: '5', name: 'North East', active: true },
    { id: '6', name: 'North West', active: true },
  ]),

  'api/familyrelationships': useEnvelope([
    { code: '1', description: 'Immediate Family', active: true },
    { code: '2', description: 'Extended Family', active: true },
  ]),
};

routes['api/communities'] = useEnvelope([
  { id: '1', name: 'Victoria (City)' },
  { id: '2', name: 'Armstrong (City)' },
  { id: '3', name: 'Belcarra (Village)' },
]);

// add data relationships
routes['api/incidenttasks'] = useEnvelope([
  { id: '1', taskNumber: '123456', description: 'Incident in a community', community: byId('api/communities', '1'), region: null },
  { id: '2', taskNumber: '456789', description: 'Incident in a region', community: null, region: byId('api/regions', '1') },
]);

// registrations
routes['api/registrations'] = useEnvelope([]);

// orgs
routes['api/organizations'] = useEnvelope([]);
routes['api/organizations/1/users'] = useEnvelope([]);

// auth route
routes['api/user/current'] = useEnvelope({
  id: '1',
  name: 'Doe, John',
  firstname: 'John',
  lastname: 'Doe',
  email: 'jdoe@some-email.com',
  isNewUser: false,
});


// mocking server-side API for now
export function httpGet(url = 'api/not-found', options?) {
  console.log(`fetching '${url}'`)
  const mockResponse = routes[matchRoute(url)];
  return of(mockResponse);
}

// private
function matchRoute(url = 'api/not-found'): any {
  return Object.keys(routes).find(path => url.endsWith(path))
}

function byId(url = 'api/not-found', id: string): any {
  const payload: { data?: any[]; error?: any; } = routes[matchRoute(url)];
  const { data, error } = payload;
  if (error) {
    return null;
  }
  return (data || []).find(x => x.id == id);
}

function useEnvelope(response: any, skip = false) {
  if (skip) {
    return response;
  }
  return { data: response };
}
