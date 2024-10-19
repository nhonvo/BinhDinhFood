import { useForm } from 'react-hook-form'
import { Link, useNavigate } from 'react-router-dom'
import { ISignUpForm } from './SignUp.types'
import { yupResolver } from '@hookform/resolvers/yup'
import SignUpSchema from './SignUp.schema'
import { SpinnerCircular } from 'spinners-react'
import { toast } from 'react-hot-toast'
import { useSignUpMutation } from '../../services'
import { useEffect } from 'react'
import { ErrorMessage } from '@hookform/error-message'
import { TAuthErrorResponse } from '../../shared/types/Auth.types'
import { Button, FormError, FormInput, FormLabel } from '../../components'

function SignUp() {
  const navigate = useNavigate()
  window.document.title = 'BinhDinhFood - Sign Up'
  const [signUp, { isLoading, isSuccess, error, isError, data }] = useSignUpMutation()
  const {
    register,
    handleSubmit,
    formState: { errors },
    setError,
    setFocus
  } = useForm<ISignUpForm>({
    resolver: yupResolver(SignUpSchema)
  })

  const signUpHandler = async (data: ISignUpForm) => {
    await signUp({
      email: data.email,
      name: data.name,
      userName: data.userName,
      password: data.password
    })
  }

  useEffect(() => {
    if (isSuccess) {
      toast.success("Register successfully!");
      navigate('/sign-in');
    }
  }, [isSuccess, navigate]);

  useEffect(() => {
    if (isError) {
      let errorMessage = "An unknown error occurred.";

      // Check if error has the expected structure
      if (error && 'data' in error) {
        const errorData = error.data as TAuthErrorResponse;

        if (errorData.errorCode) {
          errorMessage = errorData.message;
        }

        // Handle specific error messages for email and username
        if (errorMessage === 'The email address is available.') {
          setError('email', { message: errorMessage });
          setFocus('email');
        } else if (errorMessage === 'The username is available.') {
          setError('userName', { message: errorMessage });
          setFocus('userName');
        }
      } else {
        toast.error("Registration failed. Please try again.", { position: 'bottom-center' });
        return;
      }
      toast.error(errorMessage, { position: 'bottom-center' });
    }
  }, [isError, error, setError, setFocus]);

  return (
    <div className='max-w-[400px] w-full'>
      <div className='space-y-5 mb-7'>
        <Link to='/' aria-label='go back to landing page'>
          <svg
            width='24'
            height='24'
            viewBox='0 0 24 24'
            fill='none'
            xmlns='http://www.w3.org/2000/svg'
          >
            <path
              d='M11 6.5L5.5 12M5.5 12L11 17.5M5.5 12H20'
              stroke='#262D33'
              strokeWidth='1.2'
            />
          </svg>
        </Link>
        <h2 className='text-3xl font-bold text-text-3xl leading-[150%]'>
          Register Account
        </h2>
        <p className='text-lg text-neutral-dark-grey leading-[150%]'>
          Let's create your account
        </p>
      </div>

      <div>
        <form className='space-y-7' onSubmit={handleSubmit(signUpHandler)}>
          <div className='space-y-[8px]'>
            <FormLabel htmlFor='email'>Email</FormLabel>
            <FormInput
              type='email'
              id='email'
              autoComplete='off'
              {...register('email', { required: true })}
            />
            <ErrorMessage
              errors={errors}
              name='email'
              render={({ message }) => <FormError>{message}</FormError>}
            />
          </div>
          <div className='space-y-[8px]'>
            <FormLabel htmlFor='full-name'>Full Name</FormLabel>
            <FormInput
              type='text'
              id='full-name'
              autoComplete='off'
              {...register('name', { required: true })}
            />
            <ErrorMessage
              errors={errors}
              name='name'
              render={({ message }) => <FormError>{message}</FormError>}
            />
          </div>
          <div className='space-y-[8px]'>
            <FormLabel htmlFor='user-name'>User Name</FormLabel>
            <FormInput
              type='text'
              id='user-name'
              autoComplete='off'
              {...register('userName', { required: true })}
            />
            <ErrorMessage
              errors={errors}
              name='userName'
              render={({ message }) => <FormError>{message}</FormError>}
            />
          </div>
          <div className='space-y-[8px]'>
            <FormLabel htmlFor='password'>Password</FormLabel>
            <FormInput
              type='password'
              id='password'
              autoComplete='new-password'
              {...register('password', { required: true })}
            />
            <ErrorMessage
              errors={errors}
              name='password'
              render={({ message }) => <FormError>{message}</FormError>}
            />
          </div>
          <div className='space-y-[8px]'>
            <FormLabel htmlFor='confirmation-password'>
              Confirmation Password
            </FormLabel>
            <FormInput
              type='password'
              id='confirmation-password'
              autoComplete='new-password'
              {...register('confirmPassword', { required: true })}
            />
            <ErrorMessage
              errors={errors}
              name='confirmPassword'
              render={({ message }) => <FormError>{message}</FormError>}
            />
          </div>
          <div className='flex items-start gap-2'>
            <input
              type='checkbox'
              className={`form-checkbox rounded-full !outline-none focus:!outline-none focus:!border-none text-primary-black w-5 h-5 border-none ring-primary-black ring-1 focus:ring-transparent ring-offset-0 focus:ring-offset-0 ${errors.acceptTerms ? ' !ring-red-500 focus:!ring-red-500' : ''
                }`}
              id='acceptTerms'
              data-testid='accept-terms'
              {...register('acceptTerms', { required: true })}
            />
            <FormLabel htmlFor='acceptTerms' className='flex-1'>
              <p
                className={`text-text-xs text-neutral-dark-grey leading-[150%] `}
              >
                By creating your account, you agree to our{' '}
                <span className='text-black'>Terms and Conditions</span> &{' '}
                <span className='text-black'>Privacy Policy</span>
              </p>
            </FormLabel>
          </div>
          <Button type='submit' disabled={isLoading}>
            {isLoading ? (
              <SpinnerCircular
                size={45}
                thickness={117}
                speed={132}
                color='rgba(255, 255, 255, 1)'
                secondaryColor='rgba(38, 45, 51, 1)'
                className='m-auto'
              />
            ) : (
              'CREATE'
            )}
          </Button>
        </form>

        <p className='text-neutral-dark-grey text-text-sm mt-7'>
          Already have an account?{' '}
          <Link
            to='/sign-in'
            className='text-sm font-medium text-primary-black'
          >
            Login
          </Link>
        </p>
      </div>
    </div>
  )
}

export default SignUp
